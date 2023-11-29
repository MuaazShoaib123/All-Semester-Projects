const Logs = require('../models/Log');
async function addlogs(req, res) {

    try {   
        const logs = await Logs.create(req.body);
        res.status(201).json(logs);

    } catch (error) {
        
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}
module.exports = {
    addlogs,
};