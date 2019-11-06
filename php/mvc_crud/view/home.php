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
                    <a href="index.php?edit=<?php echo $row['id']; ?>">Edit</a>
                    <a href="index.php?delete=<?php echo $row['id']; ?>">Delete</a>
                </td>
            </tr>
        <?php endwhile; ?>
    </table>
    <?php if($controller->update == true): ?>
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
            <button type="submit" name="update">Update</button>
        </div>
    </form>
    <?php endif; ?>
</div>