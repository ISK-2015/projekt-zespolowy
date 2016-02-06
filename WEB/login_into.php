<?php

/* dzia�anie logowania */

session_start();

require_once('connect.php');

$connect = @new mysqli($host,$db_user,$db_password,$db_name); //��czenie z baz�, mysqli i-improved, @-wycisza b��dy

	if ($connect -> connect_errno!=0)
	{
		echo "Error: ".$connect->connect_errno; // 'error' a nie b��d, bo nie ma zadeklarowanego utf-8 i mo�e sie krzaczy�
	}
	else
	{
		$login = $_POST['login'];
		$password = $_POST['password'];
		
		$login = htmlentities($login, ENT_QUOTES, "UTF-8"); // ma niby ochroni� przed wstrzykiwaniem zapyta�, sanityzacja
		$password = htmlentities($password, ENT_QUOTES, "UTF-8");
				
		if ($result = @$connect->query(	// zapytanie, sprawdzaj�ce, czy jest taki klient
		sprintf("SELECT * FROM tb_client WHERE user='%s'",
		mysqli_real_escape_string($connect,$login), // te� chroni przed wstrzykiwaniem sql
		mysqli_real_escape_string($connect,$password))))
		{
			$how_many_users = $result->num_rows;
			if($how_many_users>0)
			{
				$line = $result->fetch_assoc();
				if (password_verify($password, $line['pass']))
			   {
				$_SESSION['online'] = true; //flaga
				
				$a = $line['user'];
				$_SESSION['user_session'] = '<a href="user.php">'.$a.'</a>'; // po zalogowaniu wy�wietla nazw� u�ytkownika w menu po prawej stronie
				
				unset($_SESSION['error_session']);
				$result->free_result(); // zwalniam pami��
				header('Location: index.php');
			   } 
				else
				{
				$_SESSION['error_session'] = true; // ! nie chce mi tego wy�wietli� !!!!!
					header('Location: login.php');
				}
			}
		   else
			{
				$_SESSION['error_session'] = true; // ! nie chce mi tego wy�wietli� !!!!!
				header('Location: login.php');
			}
		
		
		}
		
		$connect->close(); // zamyka po��czenie, je�eli si� po��czy�o
	}
?>