<?php

    class Model{

        public $mysqli;
        
        public function __construct(){
            $this->mysqli = new mysqli('localhost:3308', 'root', '', 'crudmvc') or die(mysqli_error($this->mysqli));
        }

        public function getAllData(){
            $data = $this->mysqli->query("SELECT * FROM studentdetails") or die($this->mysqli->error);
            return $data;
        }

        public function getOneData($id){
            $data = $this->mysqli->query("SELECT * FROM studentdetails WHERE id=$id") or die($this->mysqli->error());
            return $data;
        }

        public function saveData($fName, $lName, $age, $district){
            $this->mysqli->query("INSERT INTO studentdetails (fName, lName, age, district) VALUE ('$fName','$lName','$age','$district')") or die($this->mysqli->error);
        }

        public function deleteData($id){
            $this->mysqli->query("DELETE FROM studentdetails WHERE id=$id") or die($this->mysqli->error());
        }

        public function updateData($id, $fName, $lName, $age, $district){
            $this->mysqli->query("UPDATE studentdetails SET fName='$fName', lName='$lName', age='$age', district='$district' WHERE id=$id") or die($this->mysqli->error);
        }
    }
?>