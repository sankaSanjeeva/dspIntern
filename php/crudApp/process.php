<?php

    session_start();
    
    $mysqli = new mysqli('localhost:3308', 'root', '', 'crudmvc') or die(mysqli_error($mysqli));

    $id = 0;
    $update = false;
    $fName = '';
    $lName = '';
    $age = '';
    $district = '';

    if(isset($_POST['save'])){
        $fName = $_POST['fName'];
        $lName = $_POST['lName'];
        $age = $_POST['age'];
        $district = $_POST['district'];

        $mysqli->query("INSERT INTO studentdetails (fName, lName, age, district) VALUES ('$fName','$lName','$age','$district')") or die($mysqli->error);

        $_SESSION['message'] = "Record has been saved...!";
        $_SESSION['msg_type'] = "success";

        header("location: index.php");
    }

    if(isset($_GET['delete'])){
        $id = $_GET['delete'];

        $mysqli->query("DELETE FROM studentdetails WHERE id=$id") or die($mysqli->error());

        $_SESSION['message'] = "Record has been deleted...!";
        $_SESSION['msg_type'] = "warning";

        header('location: index.php');
    }

    if(isset($_GET['edit'])){
        $id = $_GET['edit'];
        $result = $mysqli->query("SELECT * FROM studentdetails WHERE id=$id") or die($mysqli->error());
        //if(count($result)==1){
            $update = true;
            $row = $result->fetch_array();
            $fName = $row['fName'];
            $lName = $row['lName'];
            $age = $row['age'];
            $district = $row['district'];
        //}
    }

    if(isset($_POST['update'])){
        $id = $_POST['id'];
        $fName = $_POST['fName'];
        $lName = $_POST['lName'];
        $age = $_POST['age'];
        $district = $_POST['district'];

        $mysqli->query("UPDATE studentdetails SET fName='$fName', lName='$lName, age='$age, district='$district WHERE id=$id") or die($mysqli->error);

        $_SESSION['message'] = "Record has been updated...!";
        $_SESSION['msg_type'] = "warning";

        header('location: index.php');
    }
?>