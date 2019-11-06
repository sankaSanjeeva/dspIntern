<?php
    Route::set('index.php', function(){
        Index::CreateView('Index');
    });

    Route::set('about-us', function(){
        AboutUS::CreateView('AboutUs');
        AboutUS::test();
    });

    Route::set('contact-us', function(){
        ContactUs::CreateView('ContactUs');
    });
?>