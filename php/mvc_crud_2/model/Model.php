<?php
    class Model{

        public $mysqli;
        
        public function connect(){
            $this->mysqli = new mysqli('localhost:3308', 'root', '', 'crudmvc') or die(mysqli_error($this->mysqli));
        }

        public function getAllData(){
            $this->connect();
            $data = $this->mysqli->query("SELECT * FROM studentdetails") or die($this->mysqli->error);
            return $data;
        }
    }
?>