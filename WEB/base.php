<?php

session_start();
require_once('lib/Smarty.class.php');
$smarty = new Smarty();
$smarty -> template_dir = 'html';
$smarty -> compile_dir = 'temp';
$smarty -> cache_dir = 'cache';

require_once('connect.php');

$connect = new mysqli($host,$db_user,$db_password,$db_name); //łšczenie z bazš, mysqli i-improved, @-wycisza błędy

	if ($connect -> connect_errno!=0)
	{
		echo "Error: ".$connect->connect_errno; // 'error' a nie błšd, bo nie ma zadeklarowanego utf-8 i może sie krzaczyć
	}
	else
	{
			//zmiana kodowania na utf-8		
	 $connect->set_charset("utf8");
			
	$query = "SELECT * FROM `tb_movies` WHERE 1 ORDER BY `id_movie`";

		$wynikowa = array();
		try {
			$result   = $connect->query($query);


		      	while($row = $result->fetch_array())
			  {	
				$tablica[]=$row;
			  }

		    }//obsługa błędu
		    catch (PDOException $ex) { 
				echo "błąd bazy danych";
		    };

}
	
$smarty -> assign('tb_movies', $tablica);

$smarty -> display('base.html');

?>