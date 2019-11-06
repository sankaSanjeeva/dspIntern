<html>
    <head>
        <title>Student data</title>
    </head>
    <body>
        <?php
            include 'model/model.php';
            include 'view/view.php';
            include 'controller/controller.php';

            $model = new Model();
            $controller = new Controller($model);
            $view = new View($model);

            $data = $controller->getData();
        ?>
        <?php
            include $controller->page;
        ?>
    </body>
</html>