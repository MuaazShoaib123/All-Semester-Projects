const Budget = require('../models/budget');
const BudgetAudit = require('../models/budgetAudit');
const Logs = require('../models/Log');

// Add Budget Function
async function addbudget(req, res) {

    const { UserId, Category, Amount, oldamount } = req.body;

    try {
        const existingCategory = await Budget.findOne({ UserId, Category });

        if (existingCategory) {
            return res.status(400).json({ error: 'Category already exists. Please update or delete first.' });
        }

        const budget = await Budget.create(req.body);
        res.status(201).json(budget);

    } catch (error) {

        await Logs.create({
            TableName: 'Budget',
            functionName: 'addbudget',
            exceptionMessage: error.message,
        });
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

// Get User Budget Function
async function getuserbudget(req, res) {
    const { UserId } = req.body;

    try {
        const budgets = await Budget.find({ UserId });

        if (budgets && budgets.length > 0) {
            // Extract relevant data from budgets
            const budgetData = budgets.map(budget => ({
                Category: budget.Category,
                Amount: budget.Amount
            }));

            return res.json(budgetData);
        } else {
            return res.status(404).json({ error: "Budget data not found for the user." });
        }
    } catch (error) {

        await Logs.create({
            TableName: 'Budget',
            functionName: 'getuserbudget',
            exceptionMessage: error.message,
        });
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

// Update Function
async function update_amount(req, res) {
    const { UserId, Category, Amount } = req.body;

    try {
        // Find the budget record to update
        const budget = await Budget.findOne({ UserId, Category });

        if (!budget) {
            return res.status(404).json({ error: 'Budget not found' });
        }

        else {

            await BudgetAudit.create({
                UserId: budget.UserId,
                Category: budget.Category,
                Amount: budget.Amount,
                Action: 'update'
            });

            // Update the amount in the budget record
            budget.Amount = Amount;
            budget.oldamount = Amount;
            // Save the updated budget record
            await budget.save();
            // Send a success response
            res.json({ message: 'Amount updated successfully' });
        }
    } catch (error) {

        await Logs.create({
            TableName: 'Budget',
            functionName: 'update_amount',
            exceptionMessage: error.message,
        });
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

// Delete Budget
async function delete_budget(req, res) {
    const { UserId, Category } = req.body;

    try {
        // Find the budget record to delete
        const budget = await Budget.findOneAndDelete({ UserId, Category });

        if (!budget) {
            return res.status(404).json({ error: 'Budget not found' });
        }
        await BudgetAudit.create({
            UserId: budget.UserId,
            Category: budget.Category,
            Amount: budget.Amount,
            Action: 'delete'
        });

        budget.deleteOne();
        // Send a success response
        res.json({ message: 'Budget deleted successfully' });
    } catch (error) {

        await Logs.create({
            TableName: 'Budget',
            functionName: 'delete_budget',
            exceptionMessage: error.message,
        });
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

// Check Budget
async function checkBudget(req, res) {
    const { UserId } = req.body;

    try {
        // Find all budget entries for the user
        const budgets = await Budget.find({ UserId: UserId });

        // Check if any of the budgets have an amount of 0
        const hasZeroBudget = budgets.some(budget => budget.Amount === 0);

        if (hasZeroBudget) {
            // If any budget has an amount of 0, send a message
            res.json({ message: `You are out of your budget for one or more categories.` });
        }
    } catch (error) {

        await Logs.create({
            TableName: 'Budget',
            functionName: 'checkbudget',
            exceptionMessage: error.message,
        });
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

// Exporting the Modules
module.exports = {
    addbudget,
    getuserbudget,
    update_amount,
    delete_budget,
    checkBudget,
};