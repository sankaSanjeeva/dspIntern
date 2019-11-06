<?php
    class Register extends Controller{

        public function __construct(){
            $this->connect();
            if(isset($_POST['save'])){
                $fName = $_POST['fName'];
                $lName = $_POST['lName'];
                $age = $_POST['age'];
                $district = $_POST['district'];

                $this->mysqli->query("INSERT INTO studentdetails (fName, lName, age, district) VALUE ('$fName','$lName','$age','$district')") or die($this->mysqli->error);

                header('location: details');
            }
        }
    }
?>