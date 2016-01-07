<?php

	session_start();
	
	if (!isset($_SESSION['zalogowany']))
	{
		header('Location: index.php');
		exit();
	}
	
?>


<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="utf-8">
    <title>movie4you - wypożyczalnia dvd/blu-ray</title>
    <link href="bootstrap.css" rel="stylesheet">
    <link href="style.css" rel="stylesheet">     
</head>
<body>
    <?php
if (isset($_SESSION['user']))
  if ($_SESSION['user'] != NULL){
      echo "<p>Witaj ".$_SESSION['user'].'! [ <a href="logout.php">Wyloguj się!</a> ]</p>';            
  }

if (isset($_SESSION['email']))
  if ($_SESSION['email'] != NULL){
	echo "<p><b>E-mail</b>: ".$_SESSION['email'];
  }	
?>
    <div class="container">
      <div class="header clearfix">
        <nav>
          <ul class="nav nav-pills pull-right">
              <li><a href="index.php">home</a></li>
              <li><a href="price.php">cennik</a></li>
              <li><a href="base.php">katalog</a></li>
              <li><a href="search.php">szukaj</a></li>
              <li><a href="contact.php">kontakt</a></li>
              <li><a href="login.php">login/rejestracja</a></li>
          </ul>
        </nav>
        <a href="index.php"><img class="logo" src="obrazki/logo.jpg" alt="Logo movie4you" /></a>
      </div>
     
        <?php
        function orginal_title() {
	global $wpdb;
	$postid = get_the_ID();
	$results = $wpdb->get_results( 'SELECT orginal_title FROM `tb_movies` WHERE id_movie =1', OBJECT );
	
	echo $results[0] ->orginal_title; 
}

function translate_title() {
	global $wpdb;
	$postid = get_the_ID();
	$results = $wpdb->get_results( 'SELECT translate_title FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->translate_title; 
}

function carrier() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT carrier FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->carrier; 
}

function duration() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT duration FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->duration; 
}

function cast() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT cast FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->cast; 
}

function genre() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT genre FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->genre; 
}

function rating() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT rating FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->rating; 
}

function add_date() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT add_date FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->add_date; 
}

function direction() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT direction FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->direction; 
}

function description() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT description FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->description; 
}

function production() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT production FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->production; 
}

function country_production() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT country_production FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->country_production; 
}

function url() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT url FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->url; 
}

function scenario() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT scenario FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->scenario; 
}

function quality() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT quality FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->quality; 
}

function availability() {
	global $wpdb;
	$results = $wpdb->get_results( 'SELECT availability FROM `tb_movies` WHERE id_movie =1', OBJECT );
	echo $results[0] ->availability; 
}
        
        ?>
        
        
        
        
        
        <footer class="footer">
        <p> movie4you © 2016 </p>
      </footer>     
    </div> <!-- /container -->
</body>
</html>