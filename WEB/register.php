<?php
session_start();

if ((isset($_SESSION['online'])) && ($_SESSION['online']==true)) // jeśli zalogowany, przenosi na index.php
{
	header('Location: index.php');
	exit();
}

require_once('lib/Smarty.class.php');
$smarty = new Smarty();
$smarty -> template_dir = 'html';
$smarty -> compile_dir = 'temp';
$smarty -> cache_dir = 'cache';


	if (isset($_POST['email']))
	{
		//Udana walidacja? Załóżmy, że tak!
		$everything_ok=true;
		
                //Sprawdź poprawność loginname'a
		$login = $_POST['login'];
		
		//Sprawdzenie długości logina
		if ((strlen($login)<3) || (strlen($login)>20))
		{
			$everything_ok=false;
			$_SESSION['e_login']="login musi posiadać od 3 do 20 znaków!";
		}
		
		if (ctype_alnum($login)==false)
		{
			$everything_ok=false;
			$_SESSION['e_login']="login może składać się tylko z liter i cyfr (bez polskich znaków)";
		}
		//sprawdzanie poprawnosci nazwiska 
                $surname = $_POST['surname'];
                //
                if (!preg_match('/^[A-ZŁŚ]{1}+[a-ząęółśżźćń]+$/',$surname) )     
                 {
                        $everything_ok=false;
			$_SESSION['e_surname']="Podaj nazwisko z dużej litery   ";
                 }
                 //sprawdzanie poprawnosci imie
                $name = $_POST['name'];
           
                 if (!preg_match('/^[A-ZŁŚ]{1}+[a-ząęółśżźćń]+$/',$name) )     
                 {
                        $everything_ok=false;
			$_SESSION['e_name']="Podaj imie z dużej litery ";
                 }
                  //sprawdzanie poprawnosci miasto
                $town = $_POST['town'];
             
                if (!preg_match('/^[A-ZŁŚ]{1}+[a-ząęółśżźćń]+$/',$town) )     
                 {
                        $everything_ok=false;
			$_SESSION['e_town']="Podaj misato z dużej litery  ";
                 }
                  //sprawdzanie poprawnosci ulica 
                 $street = $_POST['street'];
                
                if (!preg_match('/^[a-ząęółśżźćń]+$/',$street) )     
                 {
                        $everything_ok=false;
			$_SESSION['e_street']="Podaj ulicę bez cyfr i kropek ";
                 }
               
                 //sprawdzanie poprawnosci kod pocztowy 
                 $past_cod = $_POST['past_cod'];
            
                 if (!preg_match('/^[0-9]{2}-?[0-9]{3}$/Du',$past_cod) ) 
                {
                        $everything_ok=false;
			$_SESSION['e_past_cod']="Wprowadzono błędny kod pocztowy";
                }
                
                //sprawdzanie poprawnosci numer telefonu 
                $phone_namber = $_POST['phone_namber'];
              
                 if (!preg_match('#[0-9\+]{3,}#',$phone_namber) ) 
                {
                        $everything_ok=false;
			$_SESSION['e_phone_namber']="Wprowadzono błędny Numer telefon";
                }

                // Sprawdź poprawność adresu email
		$email = $_POST['email'];
		$emailB = filter_var($email, FILTER_SANITIZE_EMAIL);
		
		if ((filter_var($emailB, FILTER_VALIDATE_EMAIL)==false) || ($emailB!=$email))
		{
			$everything_ok=false;
			$_SESSION['e_email']="Podaj poprawny adres e-mail!";
		}
		
		//Sprawdź poprawność hasła
		$password = $_POST['password'];
		$haslo2 = $_POST['haslo2'];
		
		if ((strlen($password)<8) || (strlen($password)>20))
		{
			$everything_ok=false;
			$_SESSION['e_haslo']="Hasło musi posiadać od 8 do 20 znaków!";
		}
		
		if ($password!=$haslo2)
		{
			$everything_ok=false;
			$_SESSION['e_haslo']="Podane hasła nie są identyczne!";
		}	

		$haslo_hash = password_hash($password, PASSWORD_DEFAULT);
	
		//Czy zaakceptowano regulamin?
		if (!isset($_POST['regulamin']))
		{
			$everything_ok=false;
			$_SESSION['e_regulamin']="Potwierdź akceptację regulaminu!";
		}				
		
       
           if (isset($_POST['regulamin'])) $_SESSION['fr_regulamin'] = true;
		
		require_once "connect.php";
		mysqli_report(MYSQLI_REPORT_STRICT);
		
		try 
		{
			$connect = new mysqli($host, $db_user, $db_password, $db_name);
			if ($connect->connect_errno!=0)
			{
				throw new Exception(mysqli_connect_errno());
			}
			else
			{
                            
				//Czy email już istnieje?
				$rezultat = $connect->query("SELECT id FROM tb_client WHERE email='$email'");
				
				if (!$rezultat) throw new Exception($connect->error);
				
				$ile_takich_maili = $rezultat->num_rows;
				if($ile_takich_maili>0)
				{
					$everything_ok=false;
					$_SESSION['e_email']="Istnieje już konto przypisane do tego adresu e-mail!";
				}		

				//Czy login jest już zarezerwowany?
				$rezultat = $connect->query("SELECT id FROM tb_client WHERE user='$login'");
				
				if (!$rezultat) throw new Exception($connect->error);
				
				$ile_takich_nickow = $rezultat->num_rows;
				if($ile_takich_nickow>0)
				{
					$everything_ok=false;
					$_SESSION['e_login']="Istnieje już użytkownik o takim loginu! Wybierz inny.";
				}
				
				if ($everything_ok==true)
				{
					//Hurra, wszystkie testy zaliczone, dodajemy gracza do bazy
					
					if ($connect->query("INSERT INTO tb_client    VALUES (NULL, '$login', '$haslo_hash', '$email','$name','$surname','$town','$street','$past_cod','$phone_namber')"))
					{
						$_SESSION['udanarejestracja']=true;
						header('Location: witamy.php');
					}
					else
					{
						throw new Exception($connect->error);
					}
					
				}
				
				$connect->close();
			}
			
		}
		catch(Exception $e)
		{
			echo '<span style="color:red;">Błąd serwera! Przepraszamy za niedogodności i prosimy o rejestrację w innym terminie!</span>';
			echo '<br />Informacja developerska: '.$e;
		}
		
	}
	
	
?>

$smarty -> display('register.html');
?>