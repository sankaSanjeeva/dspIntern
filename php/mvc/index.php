<?php
    include 'model/model.php';
    include 'view/view.php';
    include 'controller/controller.php';

    $model = new Model();
    $controller = new Controller($model);
    $view = new View($model);

    echo $view->outPut();
?>