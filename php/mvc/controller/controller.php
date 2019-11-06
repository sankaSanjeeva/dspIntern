<?php
    class Controller{
        private $model;

        public function __construct($model){
            //Set model
            $this->model = $model;

            if(isset($_GET['uinput']) && !empty($_GET['uinput'])){
                $this->updateModel($_GET['uinput']);
            }
        }

        private function updateModel($data){
            $this->model->setData($data);
        }
    }
?>