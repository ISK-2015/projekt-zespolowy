<?php

	session_start();
	
	if (!isset($_SESSION['zalogowany']))
	{
		
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
      <footer class="footer">
        <p> movie4you © 2016 </p>
      </footer>
    </div> <!-- /container -->
</body>
</html>