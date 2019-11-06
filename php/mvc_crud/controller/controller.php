<?php
    class Controller{
        private $model;

        // To set page
        public $page = "view/home.php";

        // To set the value in input fields
        public $update = false;
        public $id = '';
        public $fName = '';
        public $lName = '';
        public $age = '';
        public $district = '';

        public function __construct($model){
            $this->model = $model; 

            // To get page
            if(isset($_GET['home'])){
                $this->page = "view/home.php";
            }

            if(isset($_GET['form'])){
                $this->page = "view/form.php";
            }

            // access GET & POST requests
            if(isset($_GET['delete'])){
                $this->deleteData($_GET['delete']);
            }

            if(isset($_GET['edit'])){
                $data = $this->model->getOneData($_GET['edit']);
                $row = $data->fetch_array();
                $this->update = true;
                $this->id = $row['id'];
                $this->fName = $row['fName'];
                $this->lName = $row['lName'];
                $this->age = $row['age'];
                $this->district = $row['district'];
            }

            if(isset($_POST['save'])){
                $this->saveData($_POST['fName'], $_POST['lName'], $_POST['age'], $_POST['district']);
                header('location: index.php');
            }

            if(isset($_POST['update'])){
                $this->updateData($_POST['id'], $_POST['fName'], $_POST['lName'], $_POST['age'], $_POST['district']);
                header('location: index.php');
            }
        }

        public function getData(){
            return $this->model->getAllData();
        }

        public function saveData($fName, $lName, $age, $district){
            $this->model->saveData($fName, $lName, $age, $district);
        }

        public function deleteData($id){
            $this->model->deleteData($id);
        }

        public function updateData($id, $fName, $lName, $age, $district){
            $this->model->updateData($id, $fName, $lName, $age, $district);
        }
    }
?>