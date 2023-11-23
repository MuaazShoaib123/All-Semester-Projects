const express = require('express');
const router = express.Router();
const userscontroller = require('../controllers/usercontroller');
const budgetcontroller = require('../controllers/budgetcontroller');
router.post('/addusers',userscontroller.adduser);
router.post('/loginuser',userscontroller.login);
router.post('/getid',userscontroller.getuserid);
router.post('/addbudget',budgetcontroller.addbudget);
router.post('/getuserbudget',budgetcontroller.getuserbudget);
router.post('/updateamount',budgetcontroller.update_amount);
router.post('/deletebudget',budgetcontroller.delete_budget);

module.exports = router;