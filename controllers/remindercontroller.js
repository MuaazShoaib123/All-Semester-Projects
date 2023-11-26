const Reminder = require('../models/reminders')

async function addreminder(req, res) {


    try {

        const reminder = await Reminder.create(req.body);
        res.status(201).json(reminder);

    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}

async function getuserreminder(req, res) {
    const { UserId } = req.body;

    try {
        const reminder = await Reminder.find({ UserId });

        if (reminder && reminder.length > 0) {
            // Extract relevant data from budgets
            const reminderData = reminder.map(reminder => ({

                Category: reminder.Category,
                Description: reminder.Description,
                Date: reminder.Date,
                Time: reminder.Time,
                Status: reminder.Status
            }));

            return res.json(reminderData);
        } else {
            return res.status(404).json({ error: "Reminder data not found for the user." });
        }
    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}
async function delete_reminder(req, res) {
    const { UserId, Category } = req.body;

    try {

        const reminder = await Reminder.findOneAndDelete({ UserId, Category });

        if (!reminder) {
            return res.status(404).json({ error: 'Reminder not found' });
        }
        // Send a success response
        res.json({ message: 'Expense deleted successfully' });
    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}
async function update_description(req, res) {
    const { UserId, Category, Description } = req.body;

    try {

        const reminder = await Reminder.findOne({ UserId, Category });
        if (!reminder) {
            return res.status(404).json({ error: 'Reminder not found' });
        }

        else {
            // Update the amount in the budget record
            reminder.Description = Description;
            await reminder.save();
            // Send a success response
            res.json({ message: 'Reminder Updated Successfully' });
        }
    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}
async function update_date(req, res) {

    const { UserId, Category, Date, date2 } = req.body;

    try {

        const reminder = await Reminder.findOne({ UserId, Category });
        if (!reminder) {
            return res.status(404).json({ error: 'Reminder not found' });
        }

        else {
            // Update the amount in the budget record
            reminder.Date = Date;
            if (reminder.Date != date2) {

                reminder.Status = "Inactive";
            }
            if (reminder.Date == date2) {

                reminder.Status = "Active";
            }
            await reminder.save();
            // Send a success response
            res.json({ message: 'Reminder Updated Successfully' });
        }
    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}
async function update_time(req, res) {
    const { UserId, Category, Time } = req.body;

    try {

        const reminder = await Reminder.findOne({ UserId, Category });
        if (!reminder) {
            return res.status(404).json({ error: 'Reminder not found' });
        }

        else {
            // Update the amount in the budget record
            reminder.Time = Time;
            await reminder.save();
            // Send a success response
            res.json({ message: 'Reminder Updated Successfully' });
        }
    } catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}
async function checkdateandtime(req, res) {
    const { UserId, Date } = req.body;

    try {
        const reminders = await Reminder.find({ UserId, Date });
        if (reminders.length > 0) {
            // If there are reminders with the same UserId, Date, and Time
            for (const reminder of reminders) {
                reminder.Status = "Active";
                await reminder.save();
            }
            const messages = reminders.map(reminder => `Reminder: ${reminder.Description}.`);
            res.json({ messages });
        }
        else {
            // If there are no reminders with the same UserId, Date, and Time
            res.json({ message: 'No matching reminders found.' });
        }

    }
    catch (error) {
        console.error('Error:', error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
}
module.exports = {
    addreminder,
    getuserreminder,
    update_description,
    update_date,
    update_time,
    delete_reminder,
    checkdateandtime,
};