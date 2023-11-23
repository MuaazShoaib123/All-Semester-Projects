const Budget = require ('../models/budget')

async function addbudget (req,res){

    const { UserId, Category, Amount, oldamount} = req.body;

    try {
        const existingCategory = await Budget.findOne({ UserId, Category });

        if (existingCategory) {
            return res.status(400).json({ error: 'Category already exists. Please update or delete first.' });
        }

            const budget = await Budget.create(req.body);
            res.status(201).json(budget);
        
    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}
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
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

async function update_amount(req, res) {
    const { UserId, Category, Amount } = req.body;

    try {
        // Find the budget record to update
        const budget = await Budget.findOne({ UserId ,Category});

        if (!budget) {
            return res.status(404).json({ error: 'Budget not found' });
        }
        
        else{
        // Update the amount in the budget record
        budget.Amount = Amount;
        budget.oldamount = Amount;
        // Save the updated budget record
        await budget.save();

        // Send a success response
        res.json({ message: 'Amount updated successfully' });
        }
    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

async function delete_budget(req, res) {
    const { UserId, Category } = req.body;

    try {
        // Find the budget record to delete
        const budget = await Budget.findOneAndDelete({ UserId, Category });

        if (!budget) {
            return res.status(404).json({ error: 'Budget not found' });
        }
        // Send a success response
        res.json({ message: 'Budget deleted successfully' });
    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

async function checkBudget(req,res) {
    const { UserId } = req.body;

    try {
       
        const budget = await Budget.findOne({ UserId: UserId });

        if ( budget.Amount === 0) {
            
            res.json({ message: `You are out of your budget for the ${budget.Category} category.` });
        }
        // No budget or budget is not 0
    } catch (error) {
        console.error('Error:', error);
        throw new Error('Internal Server Error');
    }
}

module.exports = {
    addbudget,
    getuserbudget,
    update_amount,
    delete_budget,
    checkBudget,
};