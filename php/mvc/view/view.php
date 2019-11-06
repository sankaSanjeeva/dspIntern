<?php
    class View{
        public $model;

        public function __construct($model){
            $this->model = $model;
        }

        public function outPut(){
            //Here we prepare html page that will be displayed to user
            $html = '<p>' . $this->model->getData() . '</p>' .
            '</br><a href="index.php?uinput=This is new data">Update</a>';
            return $html;
        }
    }
?>