<?php
    Route::set('index.php', function(){
        Index::CreateView('Index');
    });

    Route::set('details', function(){
        Details::CreateView('Details');
    });

    Route::set('register', function(){
        Register::CreateView('Register');
    });
?>