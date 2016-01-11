<?php

/* dzia³anie logowania */

session_start();

require_once('connect.php');

$connect = @new mysqli($host,$db_user,$db_password,$db_name); //³¹czenie z baz¹, mysqli i-improved, @-wycisza b³êdy

	if ($connect -> connect_errno!=0)
	{
		echo "Error: ".$connect->connect_errno; // 'error' a nie b³¹d, bo nie ma zadeklarowanego utf-8 i mo¿e sie krzaczyæ
	}
	else
	{
		$login = $_POST['login'];
		$password = $_POST['password'];
		
		$login = htmlentities($login, ENT_QUOTES, "UTF-8"); // ma niby ochroniæ przed wstrzykiwaniem zapytañ, sanityzacja
		$password = htmlentities($password, ENT_QUOTES, "UTF-8");
				
		if ($result = @$connect->query(	// zapytanie, sprawdzaj¹ce, czy jest taki klient
		sprintf("SELECT * FROM tb_client WHERE user='%s' AND pass='%s'",
		mysqli_real_escape_string($connect,$login), // te¿ chroni przed wstrzykiwaniem sql
		mysqli_real_escape_string($connect,$password))))
		{
			$how_many_users = $result->num_rows;
			if($how_many_users>0)
			{
				$_SESSION['online'] = true; //flaga
				$line = $result->fetch_assoc();
				$_SESSION['user_session'] = $line['user'];
				
				unset($_SESSION['error_session']);
				$result->free_result(); // zwalniam pamiêæ
				header('Location: index.php');
			} 
			else
			{
				$_SESSION['error_session'] = true; // ! nie chce mi tego wyœwietliæ !!!!!
				header('Location: login.php');
			}
		}
		
		$connect->close(); // zamyka po³¹czenie, je¿eli siê po³¹czy³o
	}
?>