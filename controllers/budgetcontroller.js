const Budget = require ('../models/budget')

async function addbudget (req,res){

    const { UserId, BudgetCategory, Amount } = req.body;

    try {
        const existingCategory = await Budget.findOne({ UserId, BudgetCategory });

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


// async function check_category (req,res){
   
//     const {UserId,Category} = req.body;
  
//     try {
//       const check = await Budget.findOne({ UserId });
  
//       if (Category != check.BudgetCategory) {
          
//           return res.json(Category)
//       } else {
//           return res.status(401).json({ error: "Budget Category all ready added! You should update or delete first..!" });
//       }
//   } catch (error) {
//       res.status(500).json({ error: 'Internal Server Error' });
//   }
  
//   }
module.exports = {
    addbudget,
};