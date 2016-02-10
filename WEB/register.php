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
		$wszystko_OK=true;
		
                //Sprawdź poprawność loginname'a
		$login = $_POST['login'];
		
		//Sprawdzenie długości logina
		if ((strlen($login)<3) || (strlen($login)>20))
		{
			$wszystko_OK=false;
			$_SESSION['e_login']="login musi posiadać od 3 do 20 znaków!";
		}
		
		if (ctype_alnum($login)==false)
		{
			$wszystko_OK=false;
			$_SESSION['e_login']="login może składać się tylko z liter i cyfr (bez polskich znaków)";
		}
		//sprawdzanie poprawnosci nazwiska 
                $surname = $_POST['surname'];
                //
                if (!preg_match('/^[A-ZŁŚ]{1}+[a-ząęółśżźćń]+$/',$surname) )     
                 {
                        $wszystko_OK=false;
			$_SESSION['e_surname']="Podaj nazwisko z dużej litery   ";
                 }
                 //sprawdzanie poprawnosci imie
                $name = $_POST['name'];
           
                 if (!preg_match('/^[A-ZŁŚ]{1}+[a-ząęółśżźćń]+$/',$name) )     
                 {
                        $wszystko_OK=false;
			$_SESSION['e_name']="Podaj imie z dużej litery ";
                 }
                  //sprawdzanie poprawnosci miasto
                $town = $_POST['town'];
             
                if (!preg_match('/^[A-ZŁŚ]{1}+[a-ząęółśżźćń]+$/',$town) )     
                 {
                        $wszystko_OK=false;
			$_SESSION['e_town']="Podaj misato z dużej litery  ";
                 }
                  //sprawdzanie poprawnosci ulica 
                 $street = $_POST['street'];
                
                if (!preg_match('/^[a-ząęółśżźćń]+$/',$street) )     
                 {
                        $wszystko_OK=false;
			$_SESSION['e_street']="Podaj ulicę bez cyfr i kropek ";
                 }
               
                 //sprawdzanie poprawnosci kod pocztowy 
                 $past_cod = $_POST['past_cod'];
            
                 if (!preg_match('/^[0-9]{2}-?[0-9]{3}$/Du',$past_cod) ) 
                {
                        $wszystko_OK=false;
			$_SESSION['e_past_cod']="Wprowadzono błędny kod pocztowy";
                }
                
                //sprawdzanie poprawnosci numer telefonu 
                $phone_namber = $_POST['phone_namber'];
              
                 if (!preg_match('#[0-9\+]{3,}#',$phone_namber) ) 
                {
                        $wszystko_OK=false;
			$_SESSION['e_phone_namber']="Wprowadzono błędny Numer telefon";
                }

                // Sprawdź poprawność adresu email
		$email = $_POST['email'];
		$emailB = filter_var($email, FILTER_SANITIZE_EMAIL);
		
		if ((filter_var($emailB, FILTER_VALIDATE_EMAIL)==false) || ($emailB!=$email))
		{
			$wszystko_OK=false;
			$_SESSION['e_email']="Podaj poprawny adres e-mail!";
		}
		
		//Sprawdź poprawność hasła
		$password = $_POST['password'];
		$haslo2 = $_POST['haslo2'];
		
		if ((strlen($password)<8) || (strlen($password)>20))
		{
			$wszystko_OK=false;
			$_SESSION['e_haslo']="Hasło musi posiadać od 8 do 20 znaków!";
		}
		
		if ($password!=$haslo2)
		{
			$wszystko_OK=false;
			$_SESSION['e_haslo']="Podane hasła nie są identyczne!";
		}	

		$haslo_hash = password_hash($password, PASSWORD_DEFAULT);
	
		//Czy zaakceptowano regulamin?
		if (!isset($_POST['regulamin']))
		{
			$wszystko_OK=false;
			$_SESSION['e_regulamin']="Potwierdź akceptację regulaminu!";
		}				
		
	
		//Zapamiętaj wprowadzone dane
		$_SESSION['fr_login'] = $login;
		$_SESSION['fr_email'] = $email;
		$_SESSION['fr_password'] = $password;
		$_SESSION['fr_haslo2'] = $haslo2;
		$_SESSION['fr_name'] = $name;
                $_SESSION['fr_surname'] = $surname;
                $_SESSION['fr_town'] = $town;
                $_SESSION['fr_street'] = $street;
                $_SESSION['fr_past_cod'] = $past_cod;
                $_SESSION['fr_phone_namber'] = $phone_namber;
            
                
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
					$wszystko_OK=false;
					$_SESSION['e_email']="Istnieje już konto przypisane do tego adresu e-mail!";
				}		

				//Czy login jest już zarezerwowany?
				$rezultat = $connect->query("SELECT id FROM tb_client WHERE user='$login'");
				
				if (!$rezultat) throw new Exception($connect->error);
				
				$ile_takich_nickow = $rezultat->num_rows;
				if($ile_takich_nickow>0)
				{
					$wszystko_OK=false;
					$_SESSION['e_login']="Istnieje już użytkownik o takim loginu! Wybierz inny.";
				}
				
				if ($wszystko_OK==true)
				{
					//Hurra, wszystkie testy zaliczone, dodajemy gracza do bazy
					
					if ($connect->query("INSERT INTO tb_client    VALUES (NULL, '$login', '$haslo_hash', '$email','$name','$surname','$town','$street','$past_cod','$phone_namber')"))
					{
						$_SESSION['udanarejestracja']=true;
						header('Location: hello.php');
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

<section id="register" class="register">
	<div class="container">
		<div class="row">
			<div class="col-md-4 col-md-offset-4">
				<form method="post" action="register.php">
				
						
								<div class="form-group-login">
								<center><label>login:</label></center>
								<input type="text" value="<?php
								if (isset($_SESSION['fr_login']))
								{
									echo $_SESSION['fr_login'];
									unset($_SESSION['fr_login']);
								}
								?>" name="login" class="form-control" />
								</div>
								<?php
								if (isset($_SESSION['e_login']))
								{
									echo '<div class="error">'.$_SESSION['e_login'].'</div>';
									unset($_SESSION['e_login']);
								}
								?>
								<div class="form-group-login">
								<center><label>Twoje hasło:</label></center>
								<input type="password"  value="<?php
								if (isset($_SESSION['fr_password']))
								{
									echo $_SESSION['fr_password'];
									unset($_SESSION['fr_password']);
								}
								?>" name="password" class="form-control"/>
								 </div>
								<?php
								if (isset($_SESSION['e_haslo']))
									{
										echo '<div class="error">'.$_SESSION['e_haslo'].'</div>';
										unset($_SESSION['e_haslo']);
									}
								?>		
								<div class="form-group-login">
								<center><label>Powtórz hasło:</label></center>
								<input type="password" value="<?php
								if (isset($_SESSION['fr_haslo2']))
									{
										echo $_SESSION['fr_haslo2'];
										unset($_SESSION['fr_haslo2']);
									}
								?>" name="haslo2" class="form-control"/>
								</div>
							
								<div class="form-group-login">
								<center><label>E-mail:</label></center>
								<input type="text" value="<?php
									if (isset($_SESSION['fr_email']))
									{
										echo $_SESSION['fr_email'];
										unset($_SESSION['fr_email']);
									}
								?>" name="email"class="form-control" />
								</div>
								<?php
								if (isset($_SESSION['e_email']))
									{
										echo '<div class="error">'.$_SESSION['e_email'].'</div>';
										unset($_SESSION['e_email']);
									}
								?>
								<div class="form-group-login">
								<center><label>Imię:</label></center>
								<input type="text" value="<?php
								if (isset($_SESSION['fr_name']))
									{
										echo $_SESSION['fr_name'];
										unset($_SESSION['fr_name']);
									}
								?>" name="name" class="form-control"/>
								<?php
								if (isset($_SESSION['e_name']))
									{
										echo '<div class="error">'.$_SESSION['e_name'].'</div>';
										unset($_SESSION['e_name']);
									}
								?>
								<div class="form-group-login">
								<center><label>Nazwisko:</label></center>
								 <input type="text" value="<?php
								if (isset($_SESSION['fr_surname']))
									{
										echo $_SESSION['fr_surname'];
										unset($_SESSION['fr_surname']);
									}
								?>" name="surname" class="form-control"/>
								</div>
								<?php
								if (isset($_SESSION['e_surname']))
									{
										echo '<div class="error">'.$_SESSION['e_surname'].'</div>';
										unset($_SESSION['e_surname']);
									}
								?>
								<div class="form-group-login">
								<center><label>Ulica:</label></center>
								<input type="text" value="<?php
								if (isset($_SESSION['fr_street']))
									{
										echo $_SESSION['fr_street'];
										unset($_SESSION['fr_street']);
									}
								?>" name="street"class="form-control" />
								</div>
					 
								<?php
								if (isset($_SESSION['e_street']))
									{
										echo '<div class="error">'.$_SESSION['e_street'].'</div>';
										unset($_SESSION['e_street']);
									}
								?>
								<div class="form-group-login">
								<center><label>Miasto:</label></center>
								<input type="text" value="<?php
								if (isset($_SESSION['fr_town']))
									{
										echo $_SESSION['fr_town'];
										unset($_SESSION['fr_town']);
									}
						
								?>" name="town" class="form-control"/>
								</div>		
								<?php
								if (isset($_SESSION['e_town']))
									{
										echo '<div class="error">'.$_SESSION['e_town'].'</div>';
										unset($_SESSION['e_town']);
									}
								?>
								<div class="form-group-login">
								<center><label>Kod pocztowy :</label></center>
								<input type="kod_pocztowy" value="<?php
								if (isset($_SESSION['fr_past_cod']))
									{
										echo $_SESSION['fr_past_cod'];
										unset($_SESSION['fr_past_cod']);
									}
							   ?>" name="past_cod"class="form-control" />
								</div>
								<?php
								if (isset($_SESSION['e_past_cod']))
									{
										echo '<div class="error">'.$_SESSION['e_past_cod'].'</div>';
										unset($_SESSION['e_past_cod']);
									}
								?>
								<div class="form-group-login">
								<center><label> Numer Telefonu:</label></center>
								<input type="tel" value="<?php
								if (isset($_SESSION['fr_phone_namber']))
									{
										echo $_SESSION['fr_phone_namber'];
										unset($_SESSION['fr_phone_namber']);
									}
								?>" name="phone_namber" class="form-control"/>
								</div>	 
									<?php
								if (isset($_SESSION['e_phone_namber']))
									{
										echo '<div class="error">'.$_SESSION['e_phone_namber'].'</div>';
										unset($_SESSION['e_phone_namber']);
									}
								?>
								<label>
								<input type="checkbox" name="regulamin"  <?php
								if (isset($_SESSION['fr_regulamin']))
								{
									echo "checked";
									unset($_SESSION['fr_regulamin']);
								}
								?>/> Akceptuję regulamin
					
							   </label>
						
						<?php
							if (isset($_SESSION['e_regulamin']))
							{
								echo '<div class="error">'.$_SESSION['e_regulamin'].'</div>';
								unset($_SESSION['e_regulamin']);
							}
						?>	
						
					<div class="g-recaptcha" data-sitekey="6LcIeBQTAAAAABXZA_xP-gmZr2IUUalbKu6NQ85z"></div>
						
						<?php
							if (isset($_SESSION['e_bot']))
							{
								echo '<div class="error">'.$_SESSION['e_bot'].'</div>';
								unset($_SESSION['e_bot']);
							}
						?>	
						
						<br />
					
						<button type="submit"class="btn btn-default">zarejestruj</button>
												
		
			     </div>	
			</form>
		</div>
	</div>
</section>
<?php
$smarty -> display('register.html');
?>	