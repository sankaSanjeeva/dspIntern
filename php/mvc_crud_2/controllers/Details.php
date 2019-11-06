<?php
    class Details extends Controller{

        public $update = false;
        public $id = '';
        public $fName = '';
        public $lName = '';
        public $age = '';
        public $district = '';

        public function __construct(){
            $this->connect();
            if(isset($_GET['delete'])){
                $id = $_GET['delete'];
                $this->mysqli->query("DELETE FROM studentdetails WHERE id=$id") or die($this->mysqli->error());
            }

            if(isset($_GET['edit'])){
                $id = $_GET['edit'];
                $data = $this->mysqli->query("SELECT * FROM studentdetails WHERE id=$id") or die($this->mysqli->error());
                $row = $data->fetch_array();
                $this->update = true;
                $this->id = $row['id'];
                $this->fName = $row['fName'];
                $this->lName = $row['lName'];
                $this->age = $row['age'];
                $this->district = $row['district'];
            }

            if(isset($_POST['update'])){
                $id = $_POST['id'];
                $fName = $_POST['fName'];
                $lName = $_POST['lName'];
                $age = $_POST['age'];
                $district = $_POST['district'];

                $this->mysqli->query("UPDATE studentdetails SET fName='$fName', lName='$lName', age='$age', district='$district' WHERE id=$id") or die($this->mysqli->error);
                
                header('location: details');
            }
        }
    }
?>