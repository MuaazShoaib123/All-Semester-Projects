const User = require('../models/users')
const Logs = require('../models/Log');
const PasswordAudit = require('../models/passwordaudit');
// Add User Function
async function adduser(req, res) {

    try {
        const user = await User.create(req.body);
        res.status(201).json(user);
    }
    catch (err) {

        await Logs.create({
            TableName: 'User',
            functionName: 'adduser',
            exceptionMessage: error.message,
        });
        res.status(500).json({ error: err.message });
    }
}

// Login
async function login(req, res) {
    const { Email, Password } = req.body;

    try {
        const user = await User.findOne({ Email });

        if (!user) {
            return res.status(404).json({ error: 'Record not found' });
        }

        if (Password == user.Password) {

            return res.status(200).json({ message: user.FirstName + ' ' + user.LastName });
        } else {
            return res.status(401).json({ error: "Incorrect Password" });
        }
    } catch (error) {

        await Logs.create({
            TableName: 'User',
            functionName: 'login',
            exceptionMessage: error.message,
        });
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

// Get User Id
async function getuserid(req, res) {

    const { FirstName, LastName } = req.body;

    try {
        const user = await User.findOne({ FirstName });

        if (LastName == user.LastName) {

            return res.json(user._id)
        } else {
            return res.status(401).json({ error: "User not Found" });
        }
    } catch (error) {

        await Logs.create({
            TableName: 'User',
            functionName: 'getuserid',
            exceptionMessage: error.message,
        });
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

// Change Password
async function change_password(req, res) {
    const { Email, Password } = req.body;

    try {
        const user = await User.findOne({ Email });

        if (!user) {
            return res.status(404).json({ error: 'Record not found' });
        }
        
        await PasswordAudit.create({
            UserId: user.id,
            oldPassowrd: user.Password,
            Action: 'change'
        });
        user.Password = Password;
        await user.save();
        return res.json("Password Changed Successfully");
    } catch (error) {

        await Logs.create({
            TableName: 'User',
            functionName: 'change_password',
            exceptionMessage: error.message,
        });
        res.status(500).json({ error: 'Internal Server Error' });
    }
}
// Modules
module.exports = {
    adduser,
    login,
    getuserid,
    change_password,
};