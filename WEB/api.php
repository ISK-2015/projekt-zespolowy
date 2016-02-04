<?php



require_once('connect.php');

$connect = new mysqli($host,$db_user,$db_password,$db_name); //łšczenie z bazš, mysqli i-improved, @-wycisza błędy

	if ($connect -> connect_errno!=0)
	{
		echo "Error: ".$connect->connect_errno; // 'error' a nie błšd, bo nie ma zadeklarowanego utf-8 i może sie krzaczyć
	}
	else
	{
	//tlewap start
			//zmiana kodowania na utf-8		
	$connect->set_charset("utf8");
			
	$query = "SELECT * FROM `tb_movies` WHERE 1 ORDER BY `id_movie`";

		$wynikowa = array();
		try {
			$result   = $connect->query($query);

			while($row = $result->fetch_array())
			  {
				array_push($wynikowa,$row);//dodanie wszystkich wartości do tablicy wynikowej			
			  }

		    }//obsługa błędu
		    catch (PDOException $ex) { 
			$response["success"] = 0;
			$response["message"] = "Database Error(#0001). Please Try Again!";
			die(json_encode($response));
		    };

		echo json_encode($wynikowa );

}
	//tlewap end

