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

<link rel="stylesheet" type="text/css" href="js/gallerystyle.css" />

<script type="text/javascript" src="js/motiongallery.js"></script>
<script type="text/javascript" src="js/motiongallery1.js"></script>

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
              <li class="active"><a href="index.php">home</a></li>
              <li><a href="price.php">cennik</a></li>
              <li><a href="base.php">katalog</a></li>
              <li><a href="search.php">szukaj</a></li>
              <li><a href="contact.php">kontakt</a></li>
              <li><a href="login.php">login/rejestracja</a></li>
          </ul>
        </nav>
       <a href="index.php"><img class="logo" src="obrazki/logo.jpg" alt="Logo movie4you" /></a>
      </div>

  

         
  <h3 class="text_c">Najnowsze:</h3>        
 <div id="motioncontainer1" style="position:relative;overflow:hidden;">
      <div id="motiongallery1" style="position:absolute;left:0;top:0;white-space: nowrap;">
           <div id="trueContainer1" style="white-space: nowrap;">

  <ul>
    <li><a href="#"><img src="obrazki/f1.jpg"></a></li>
    <li><a href="#"><img src="obrazki/f2.jpg"></a></li>
    <li><a href="#"><img src="obrazki/f3.jpg"></a></li>
    <li><a href="#"><img src="obrazki/f4.jpg"></a></li>
    <li><a href="#"><img src="obrazki/f5.jpg"></a></li>
    <li><a href="#"><img src="obrazki/f6.jpg"></a></li>
    <li><a href="#"><img src="obrazki/f7.jpg"></a></li>
    <li><a href="#"><img src="obrazki/f8.jpg"></a></li>
    <li><a href="#"><img src="obrazki/f2.jpg"></a></li>
    <li><a href="#"><img src="obrazki/f6.jpg"></a></li>
  </ul>

    </div>
  </div>
</div>
      
  <h3 class="tekt_c">Najczęściej Wybierane: </h3>
      
   
<div id="motioncontainer" style="position:relative;overflow:hidden;">
    <div id="motiongallery" style="position:absolute;left:0;top:0;white-space: nowrap;">
        <div id="trueContainer" style="white-space: nowrap;">

    <ul>
    <li><a href="#"><img src="miniaturki/min.jpg"></a></li>
    <li><a href="#"><img src="miniaturki/min1.jpg"></a></li>
    <li><a href="#"><img src="miniaturki/min2.jpg"></a></li>
    <li><a href="#"><img src="miniaturki/min3.jpg"></a></li>
    <li><a href="#"><img src="miniaturki/min4.jpg"></a></li>
    <li><a href="#"><img src="miniaturki/min5.jpg"></a></li>
    <li><a href="#"><img src="miniaturki/min6.jpg"></a></li>

    </ul>

       </div>
    </div>
</div>
      
   
        
     <br>   
      <footer class="footer">
      <p> movie4you © 2016 </p>
      </footer>      
    </div> <!-- /container -->
</body>
</html>
