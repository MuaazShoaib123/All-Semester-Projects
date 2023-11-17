const User = require ('../models/users')

async function adduser (req,res){

    try{
        const user = await User.create(req.body);
        res.status(201).json(user);
    }
    catch (err){
        res.status(500).json({error : err.message});
    }
}


const bcrypt = require('bcrypt');

async function login(req, res) {
    const { Email, Password } = req.body;

    try {
        const user = await User.findOne({ Email });

        if (!user) {
            return res.status(404).json({ error: 'Record not found' });
        }

        if (Password == user.Password) {
            return res.status(200).json({ message: 'Login successful' });
        } else {
            return res.status(401).json({ error: "Incorrect Password" });
        }
    } catch (error) {
        res.status(500).json({ error: 'Internal Server Error' });
    }
}





module.exports = {
    adduser,
    login,
};