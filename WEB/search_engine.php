<?php
session_start();
require_once('lib/Smarty.class.php');
$smarty = new Smarty();
$smarty -> template_dir = 'html';
$smarty -> compile_dir = 'temp';
$smarty -> cache_dir = 'cache';

require_once('connect.php');

$connect = new mysqli($host,$db_user,$db_password,$db_name); 

	if ($connect -> connect_errno!=0)
	{
		echo "Error: ".$connect->connect_errno; // '
	}
	else
	{

	$connect->set_charset("utf8");
			
	$query = "SELECT id_movie, translate_title FROM tb_movies WHERE translate_title LIKE '%".$_POST['search']."%'";

	try {
		$result   = $connect->query($query);


			while($row = $result->fetch_array())
		  {	
			echo "<a href='movie.php?id=".$row['id_movie']."'>".$row['translate_title']."</a></br>";
		  }

		}//obsługa błędu
		catch (PDOException $ex) { 
			echo "błąd bazy danych";
		};
		}

?>