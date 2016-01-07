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
	<script src="http://maps.googleapis.com/maps/api/js"></script>
	<script>
		function initialize() {
		var mapProp = {
		center:new google.maps.LatLng(52.2279009,21.0013141),
		zoom:15,
		mapTypeId:google.maps.MapTypeId.ROADMAP
		};
		var map=new google.maps.Map(document.getElementById("googleMap"),mapProp);
		}
		google.maps.event.addDomListener(window, 'load', initialize);
	</script>
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
              <li class="active"><a href="contact.php">kontakt</a></li>
              <li><a href="login.php">login/rejestracja</a></li>
          </ul>
        </nav>
		
                   <a href="index.php"><img class="logo" src="obrazki/logo.jpg" alt="Logo movie4you" /></a>
		<br>
		<br>
		
             <div class="jumbotron">
          
                <p>
			movie4you Sp. z o.o. <br>
			Aleje Jerozolimskie 81, 00-803 Warszawa, Polska<br>
			<br>
			T: (+48 22) 695 09 10<br>
			F: (+48 22) 695 09 11<br>
			E: rent@movie4you.com<br>
		</p>
                
                <div id="googleMap" style="width:500px;height:380px;"></div>
               
             </div>
    </div>    
   
      <footer class="footer">
        <p> movie4you © 2016 </p>
      </footer>
    </div> <!-- /container -->
</body>
</html>
