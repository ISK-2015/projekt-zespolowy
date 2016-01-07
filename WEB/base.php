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
              <li class="active"><a href="base.php">katalog</a></li>
              <li><a href="search.php">szukaj</a></li>
              <li><a href="contact.php">kontakt</a></li>
              <li><a href="login.php">login/rejestracja</a></li>
          </ul>
        </nav>
        <a href="index.php"><img class="logo" src="obrazki/logo.jpg" alt="Logo movie4you" /></a>
      </div>
        
<?php

	$host = "serwer1585870.home.pl";
	$db_user = "18659907_0000002";
	$db_password = "pz2-isk1-sggw";
	$db_name = "18659907_0000002";


	$q = mysql_connect($host, $db_user, $db_password) or die('nie dziala serwer');
	$q = mysql_select_db($db_name) or die('padla baza');
	

/* zapytanie do konkretnej tabeli */ 
$wynik = mysql_query("SELECT * FROM tb_movies") 
or die('Błąd zapytania'); 

/* 
wyświetlamy wyniki, sprawdzamy, 
czy zapytanie zwróciło wartość większą od 0 
*/ 
if(mysql_num_rows($wynik) > 0) { 
    /* jeżeli wynik jest pozytywny, to wyświetlamy dane */ 
    echo "<table cellpadding=\"2\" border=1>"; 
    while($r = mysql_fetch_assoc($wynik)) { 
        echo "<tr>"; 
		echo "<td>".$r['id_movie']."</td>"; 
        echo "<td>".$r['orginal_title']."</td>"; 
        echo "<td>".$r['translate_title']."</td>"; 
		echo "<td>".$r['carrier']."</td>";
		echo "<td>".$r['duration']."</td>";
        echo "<td> 
      
       </td>"; 
        echo "</tr>"; 
    } 
    echo "</table>"; 
} 

?>

      <footer class="footer">
        <p> movie4you © 2016 </p>
      </footer>   
    </div> <!-- /container -->
</body>
</html>