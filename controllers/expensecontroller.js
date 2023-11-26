const Expense = require('../models/expense')
const Budget = require('../models/budget')

async function addexpense(req, res) {

    const { UserId, Category, Description, Amount } = req.body;

    try {
        const existingCategory = await Budget.findOne({ UserId, Category });

        if (existingCategory) {
            existingCategory.oldamount = existingCategory.Amount;
            existingCategory.Amount = existingCategory.Amount - Amount;

            if (existingCategory.Amount < 0) {
                existingCategory.Amount = 0;
            }


            await existingCategory.save();
            const expense = await Expense.create(req.body);
            res.status(201).json(expense);
        }

        else {

            return res.status(400).json({ error: 'Category not added to your Budget. First add that Category in Budget Page' });
        }

    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}
async function getuserexpense(req, res) {
    const { UserId } = req.body;

    try {
        const expenses = await Expense.find({ UserId });

        if (expenses && expenses.length > 0) {
            // Extract relevant data from budgets
            const expenseData = expenses.map(expense => ({

                Category: expense.Category,
                Description: expense.Description,
                Amount: expense.Amount,
                createdAt: expense.createdAt
            }));

            return res.json(expenseData);
        } else {
            return res.status(404).json({ error: "Expense data not found for the user." });
        }
    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}
async function update_amount(req, res) {
    const { UserId, Category, Amount } = req.body;
    const value = 0;
    try {
        // Find the expense record to update
        const expense = await Expense.findOne({ UserId, Category });
        const budget = await Budget.findOne({ UserId, Category });
        if (!expense) {
            return res.status(404).json({ error: 'Expense not found' });
        }

        else {
            // Update the amount in the budget record
            expense.Amount = Amount;
            budget.Amount = budget.oldamount - expense.Amount;
            await budget.save();
            // Save the updated budget record
            await expense.save();

            // Send a success response
            res.json({ message: 'Amount updated successfully' });
        }
    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

async function delete_expense(req, res) {
    const { UserId, Category } = req.body;

    try {
        // Find the expense record to delete
        const expense = await Expense.findOne({ UserId, Category });
        const budget = await Budget.findOne({ UserId, Category });
        budget.Amount = budget.Amount + expense.Amount;
        budget.oldamount = budget.Amount;
        await budget.save();
        const expense2 = await Expense.findOneAndDelete({ UserId, Category });

        if (!expense2) {
            return res.status(404).json({ error: 'Expense not found' });
        }
        // Send a success response
        res.json({ message: 'Expense deleted successfully' });
    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}


module.exports = {
    addexpense,
    getuserexpense,
    update_amount,
    delete_expense,

};
