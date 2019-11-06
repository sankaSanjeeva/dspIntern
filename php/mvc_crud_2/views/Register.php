<?php
    //require_once("./controllers/Register.php");
    $details = new Register();
?>
<div>
    <form action="register" method="post">
        <div>
            <input type="text" name="fName"  placeholder="Enter first name">
        </div>
        <div>
            <input type="text" name="lName"  placeholder="Enter last name">
        </div>
        <div>
            <input type="number" name="age"  placeholder="Enter age">
        </div>
        <div>
            <input type="text" name="district"  placeholder="Enter district">
        </div>
        <div>
            <button type="submit" name="save">Save</button>
        </div>
    </form>
</div>