<div>
    <form action="index.php" method="post">
        <input type="hidden" name="id" value="<?php echo $controller->id ?>">
        <div>
            <input type="text" name="fName" value="<?php echo $controller->fName ?>" placeholder="Enter first name">
        </div>
        <div>
            <input type="text" name="lName" value="<?php echo $controller->lName ?>" placeholder="Enter last name">
        </div>
        <div>
            <input type="number" name="age" value="<?php echo $controller->age ?>" placeholder="Enter age">
        </div>
        <div>
            <input type="text" name="district" value="<?php echo $controller->district ?>" placeholder="Enter district">
        </div>
        <div>
            <button type="submit" name="save">Save</button>
        </div>
    </form>
</div>