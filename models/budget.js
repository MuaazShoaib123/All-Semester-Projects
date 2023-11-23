const mongoose = require('mongoose')

const budgetSchema = new mongoose.Schema({
    UserId : String,
    Category : String,
    Amount : Number,
    oldamount : Number
},
{timestamps : true}
);
module.exports= mongoose.model('Budget',budgetSchema)