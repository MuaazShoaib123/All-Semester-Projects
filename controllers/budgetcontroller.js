const Budget = require ('../models/budget')

async function addbudget (req,res){

    try{
        const budget = await Budget.create(req.body);
        res.status(201).json(budget);
    }
    catch (err){
        res.status(500).json({error : err.message});
    }
}

module.exports = {
    addbudget,
};