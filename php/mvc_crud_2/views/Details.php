<?php
    //require_once("./controllers/Details.php");
    $details = new Details();
    $data = $details->getAllData();
?>
<div>
    <table>
        <thead>
            <tr>
                <th>First name</th>
                <th>Last name</th>
                <th>Age</th>
                <th>District</th>
                <th colspan="2">Action</th>
            </tr>
        </thead>
        <?php while($row = $data->fetch_assoc()): ?>
        <tr>
            <td><?php echo $row['fName']; ?></td>
            <td><?php echo $row['lName']; ?></td>
            <td><?php echo $row['age']; ?></td>
            <td><?php echo $row['district']; ?></td>
            <td>
                <a href="details?edit=<?php echo $row['id']; ?>">Edit</a>
                <a href="details?delete=<?php echo $row['id']; ?>">Delete</a>
            </td>
        </tr>
        <?php endwhile; ?>
    </table>

    <?php if($details->update == true): ?>
    <form action="details" method="post">
        <input type="hidden" name="id" value="<?php echo $details->id ?>">
        <div>
            <input type="text" name="fName" value="<?php echo $details->fName ?>" placeholder="Enter first name">
        </div>
        <div>
            <input type="text" name="lName" value="<?php echo $details->lName ?>" placeholder="Enter last name">
        </div>
        <div>
            <input type="number" name="age" value="<?php echo $details->age ?>" placeholder="Enter age">
        </div>
        <div>
            <input type="text" name="district" value="<?php echo $details->district ?>" placeholder="Enter district">
        </div>
        <div>
            <button type="submit" name="update">Update</button>
        </div>
    </form>
    <?php endif; ?>
    
</div>