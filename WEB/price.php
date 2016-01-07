<?php

	session_start();
	
	if (!isset($_SESSION['zalogowany']))
	{
		
	}
	
?>
<!DOCTYPE html>
<html lang="pl">
<head>
	<style> 
	.newspaper {
		-webkit-column-count: 2; /* Chrome, Safari, Opera */
		-moz-column-count: 2; /* Firefox */
		column-count: 2;
	}
	</style>
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
              <li class="active"><a href="price.php">cennik</a></li>
              <li><a href="base.php">katalog</a></li>
              <li><a href="search.php">szukaj</a></li>
              <li><a href="contact.php">kontakt</a></li>
              <li><a href="login.php">login/rejestracja</a></li>
          </ul>
        </nav>
		
             <a href="index.php"><img class="logo" src="obrazki/logo.jpg" alt="Logo movie4you" /></a>
		<br>
		<br>
		<div class="jumbotron">
       
                <div class="newspaper">
			<p>
			<b>Cennik:</b><br>
			<br>
			<b>DVD:</b><br>
				2015 - 10zł<br>
				2014-2012 -8zł<br>
				2011-... - 6zł<br>
				<br>
			<b>BLU-RAY:</b><br>
				2015 - 15zł<br>
				2014-2012 -12zł<br>
				2011-... - 9zł<br>
			</p>
			<p>
				<br>
				<br>
				<br>
				<br>
				Czas na zwrot: 4 dni<br>
				kara za dzień zwłoki: 2zł<br>
				maksymalna ilośc filmów do wyożyczenia na raz: 3<br>
				zniszczenie płyty: 100zł<br>
				zniszczenie pudełka: 10zł<br>
				długość rezerwacji: 1 dzień<br>
			<br>
			<br>
			</p>
		</div>
              </div>
                
                </div>
      <footer class="footer">
        <p> movie4you © 2016 </p>
      </footer>       
    </div> <!-- /container -->
</body>
</html>
