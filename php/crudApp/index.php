<html>
    <head>
        <title>Student details</title>
        <link rel="stylesheet" href="../bootstrap/css/bootstrap.min.css">
        <script src="../bootstrap/js/bootstrap.bundle.min.js"></script>
    </head>
    <body>
        <?php require_once 'process.php'; ?>

        <?php if(isset($_SESSION['message'])): ?>

        <div class="alert alert-<?=$_SESSION['msg_type']?>">
            <?php
                echo $_SESSION['message'];
                unset($_SESSION['message']);
            ?>
        </div>

        <?php endif ?>

        <?php
            $mysqli = new mysqli('localhost:3308', 'root', '', 'crudmvc') or die(mysqli_error($mysqli));
            $result = $mysqli->query("SELECT * FROM studentdetails") or die($mysqli->error);
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
                    <?php while($row = $result->fetch_assoc()): ?>
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
            </div>
        <?php
            function pre_r($array){
                echo '<pre>';
                print_r($array);
                echo '<pre>';
            }
        ?>

        <div>
            <form action="process.php" method="post">
                <input type="hidden" name="id" value="<?php echo $id; ?>">
                <div>
                    <label>First Name</label>
                    <input type="text" name="fName" value="<?php echo $fName; ?>" placeholder="Enter first name">
                </div>
                <div>
                    <label>Last Name</label>
                    <input type="text" name="lName" value="<?php echo $lName; ?>" placeholder="Enter last name">
                </div>
                <div>
                    <label>Age</label>
                    <input type="number" name="age" value="<?php echo $age; ?>" placeholder="Enter age">
                </div>
                <div>
                    <label>District</label>
                    <input type="text" name="district" value="<?php echo $district; ?>" placeholder="Enter district">
                </div>
                <div>
                    <?php if($update == true): ?>
                    <button type="submit" name="save">Update</button>
                    <?php else: ?>
                    <button type="submit" name="save">Save</button>
                    <?php endif; ?>
                </div>
            </form>
        </div>
    </body>
</html>