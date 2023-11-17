const express = require('express');
const router = express.Router();
const userscontroller = require('../controllers/usercontroller');
router.post('/addusers',userscontroller.adduser);
router.post('/loginuser',userscontroller.login);
module.exports = router;