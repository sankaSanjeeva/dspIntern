<?php
    class Model{

        private $data;

        public function __construct(){
            //Here, we prepare data...
            $this->data = "This is from model";
        }

        public function getData(){
            return $this->data;
        }

        public function setData($data){
            $this->data = $data;
        }
    }
?>