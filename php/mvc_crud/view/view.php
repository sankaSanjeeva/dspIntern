<?php
    class View{
        public $model;

        public function __construct($model){
            $this->model = $model;
        }
    }
?>
<div>
    <ul>
        <li><a href="index.php?home">Home</a></li>
        <li><a href="index.php?form">Form</a></li>
    </ul>
</div>