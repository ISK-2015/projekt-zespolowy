<?php

	session_start();
	
	if (isset($_POST['email']))
	{
		//Udana walidacja? Załóżmy, że tak!
		$wszystko_OK=true;
		
                //Sprawdź poprawność nickname'a
		$nick = $_POST['nick'];
		
		//Sprawdzenie długości nicka
		if ((strlen($nick)<3) || (strlen($nick)>20))
		{
			$wszystko_OK=false;
			$_SESSION['e_nick']="Nick musi posiadać od 3 do 20 znaków!";
		}
		
		if (ctype_alnum($nick)==false)
		{
			$wszystko_OK=false;
			$_SESSION['e_nick']="Nick może składać się tylko z liter i cyfr (bez polskich znaków)";
		}
		//sprawdzanie poprawnosci nazwiska 
                $surname = $_POST['surname'];
                //
                if (!preg_match('/^[A-ZŁŚ]{1}+[a-ząęółśżźćń]+$/',$surname) )     
                 {
                        $wszystko_OK=false;
			$_SESSION['e_surname']="Błędne Nazwisko   ";
                 }
                 //sprawdzanie poprawnosci imie
                $name = $_POST['name'];
           
                 if (!preg_match('/^[A-ZŁŚ]{1}+[a-ząęółśżźćń]+$/',$name) )     
                 {
                        $wszystko_OK=false;
			$_SESSION['e_name']="Błędne imię";
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
		$haslo1 = $_POST['haslo1'];
		$haslo2 = $_POST['haslo2'];
		
		if ((strlen($haslo1)<8) || (strlen($haslo1)>20))
		{
			$wszystko_OK=false;
			$_SESSION['e_haslo']="Hasło musi posiadać od 8 do 20 znaków!";
		}
		
		if ($haslo1!=$haslo2)
		{
			$wszystko_OK=false;
			$_SESSION['e_haslo']="Podane hasła nie są identyczne!";
		}	

		$haslo_hash = password_hash($haslo1, PASSWORD_DEFAULT);
	
		//Czy zaakceptowano regulamin?
		if (!isset($_POST['regulamin']))
		{
			$wszystko_OK=false;
			$_SESSION['e_regulamin']="Potwierdź akceptację regulaminu!";
		}				
		
	
		//Zapamiętaj wprowadzone dane
		$_SESSION['fr_nick'] = $nick;
		$_SESSION['fr_email'] = $email;
		$_SESSION['fr_haslo1'] = $haslo1;
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
			$polaczenie = new mysqli($host, $db_user, $db_password, $db_name);
			if ($polaczenie->connect_errno!=0)
			{
				throw new Exception(mysqli_connect_errno());
			}
			else
			{
                            
				//Czy email już istnieje?
				$rezultat = $polaczenie->query("SELECT id FROM tb_client WHERE email='$email'");
				
				if (!$rezultat) throw new Exception($polaczenie->error);
				
				$ile_takich_maili = $rezultat->num_rows;
				if($ile_takich_maili>0)
				{
					$wszystko_OK=false;
					$_SESSION['e_email']="Istnieje już konto przypisane do tego adresu e-mail!";
				}		

				//Czy nick jest już zarezerwowany?
				$rezultat = $polaczenie->query("SELECT id FROM tb_client WHERE user='$nick'");
				
				if (!$rezultat) throw new Exception($polaczenie->error);
				
				$ile_takich_nickow = $rezultat->num_rows;
				if($ile_takich_nickow>0)
				{
					$wszystko_OK=false;
					$_SESSION['e_nick']="Istnieje już użytkownik o takim nicku! Wybierz inny.";
				}
				
				if ($wszystko_OK==true)
				{
					//Hurra, wszystkie testy zaliczone, dodajemy gracza do bazy
					
					if ($polaczenie->query("INSERT INTO tb_client    VALUES (NULL, '$nick', '$haslo_hash', '$email','$name','$surname','$town','$street','$past_cod','$phone_namber')"))
					{
						$_SESSION['udanarejestracja']=true;
						header('Location: witamy.php');
					}
					else
					{
						throw new Exception($polaczenie->error);
					}
					
				}
				
				$polaczenie->close();
			}
			
		}
		catch(Exception $e)
		{
			echo '<span style="color:red;">Błąd serwera! Przepraszamy za niedogodności i prosimy o rejestrację w innym terminie!</span>';
			echo '<br />Informacja developerska: '.$e;
		}
		
	}
	
	
?>

<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="utf-8">
    <title>movie4you - wypożyczalnia dvd/blu-ray</title>
    <link href="bootstrap.css" rel="stylesheet">
    <link href="style.css" rel="stylesheet">
    <script src='https://www.google.com/recaptcha/api.js'></script> <!-- recaptcha-zabezpieczenie przed botami masowe konta  -->
    
</head>
<body>
    <div class="container">
      <div class="header clearfix">
        <nav>
          <ul class="nav nav-pills pull-right">
              <li ><a href="index.php">home</a></li>
              <li><a href="price.php">cennik</a></li>
            <li><a href="base.php">katalog</a></li>
                        <li><a href="search.php">szukaj</a></li>
            <li><a href="contact.php">kontakt</a></li>
            <li class="active"><a href="login.php">login/rejestracja</a></li>
          </ul>
        </nav>
       <a href="index.php"><img class="logo" src="obrazki/logo.jpg" alt="Logo movie4you" /></a>
      </div>
	
        <div class="jumbotron">
	<form method="post">
	<div class="form-register">
			
            name  : <br /> <input type="text" value="<?php
			if (isset($_SESSION['fr_name']))
			{
				echo $_SESSION['fr_name'];
				unset($_SESSION['fr_name']);
			}
		
                       ?>" name="name" /><br />
    
     
                        <?php
			if (isset($_SESSION['e_name']))
			{
				echo '<div class="error">'.$_SESSION['e_name'].'</div>';
				unset($_SESSION['e_name']);
			}
                        ?>
            
             
            
         surname  : <br /> <input type="text" value="<?php
			if (isset($_SESSION['fr_surname']))
			{
				echo $_SESSION['fr_surname'];
				unset($_SESSION['fr_surname']);
			}
		
                       ?>" name="surname" /><br />
         
          
                        <?php
                        if (isset($_SESSION['e_surname']))
                         {
                                 echo '<div class="error">'.$_SESSION['e_surname'].'</div>';
                                 unset($_SESSION['e_surname']);
                         }
                        ?>
            
            
              Nick: <br /> <input type="text" value="<?php
			if (isset($_SESSION['fr_nick']))
			{
				echo $_SESSION['fr_nick'];
				unset($_SESSION['fr_nick']);
			}
		
                       ?>" name="nick" /><br />
         
            
            	<?php
			if (isset($_SESSION['e_nick']))
			{
				echo '<div class="error">'.$_SESSION['e_nick'].'</div>';
				unset($_SESSION['e_nick']);
			}
		?>
          
            
             
              street  : <br /> <input type="text" value="<?php
			if (isset($_SESSION['fr_street']))
			{
				echo $_SESSION['fr_street'];
				unset($_SESSION['fr_street']);
			}
		
                       ?>" name="street" /><br />
        
     
		<?php
			if (isset($_SESSION['e_street']))
			{
				echo '<div class="error">'.$_SESSION['e_street'].'</div>';
				unset($_SESSION['e_street']);
			}
		?>
             
          
             
               town  : <br /> <input type="text" value="<?php
			if (isset($_SESSION['fr_town']))
			{
				echo $_SESSION['fr_town'];
				unset($_SESSION['fr_town']);
			}
		
                       ?>" name="town" /><br />
         
     
		<?php
			if (isset($_SESSION['e_town']))
			{
				echo '<div class="error">'.$_SESSION['e_town'].'</div>';
				unset($_SESSION['e_town']);
			}
		?>
       
               		
           phone_namber: <br /> <input type="tel" value="<?php
			if (isset($_SESSION['fr_phone_namber']))
			{
				echo $_SESSION['fr_phone_namber'];
				unset($_SESSION['fr_phone_namber']);
			}
		?>" name="phone_namber" /><br />
             
	        <?php
			if (isset($_SESSION['e_phone_namber']))
			{
				echo '<div class="error">'.$_SESSION['e_phone_namber'].'</div>';
				unset($_SESSION['e_phone_namber']);
			}
		?>
      
           
             past_cod: : <br /> <input type="kod_pocztowy" value="<?php
			if (isset($_SESSION['fr_past_cod']))
			{
				echo $_SESSION['fr_past_cod'];
				unset($_SESSION['fr_past_cod']);
			}
		
                       ?>" name="past_cod" /><br />
         
     
		<?php
			if (isset($_SESSION['e_past_cod']))
			{
				echo '<div class="error">'.$_SESSION['e_past_cod'].'</div>';
				unset($_SESSION['e_past_cod']);
			}
		?>
            
     
		E-mail: <br /> <input type="text" value="<?php
			if (isset($_SESSION['fr_email']))
			{
				echo $_SESSION['fr_email'];
				unset($_SESSION['fr_email']);
			}
		?>" name="email" /><br />
		
		<?php
			if (isset($_SESSION['e_email']))
			{
				echo '<div class="error">'.$_SESSION['e_email'].'</div>';
				unset($_SESSION['e_email']);
			}
		?>
		
		Twoje hasło: <br /> <input type="password"  value="<?php
			if (isset($_SESSION['fr_haslo1']))
			{
				echo $_SESSION['fr_haslo1'];
				unset($_SESSION['fr_haslo1']);
			}
		?>" name="haslo1" /><br />
		
		<?php
			if (isset($_SESSION['e_haslo']))
			{
				echo '<div class="error">'.$_SESSION['e_haslo'].'</div>';
				unset($_SESSION['e_haslo']);
			}
		?>		
		
		Powtórz hasło: <br /> <input type="password" value="<?php
			if (isset($_SESSION['fr_haslo2']))
			{
				echo $_SESSION['fr_haslo2'];
				unset($_SESSION['fr_haslo2']);
			}
		?>" name="haslo2" /><br />
	
  
                
                
		<label>
			<input type="checkbox" name="regulamin" <?php
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
		
		<input type="submit" value="Zarejestruj się" />
	</div>	
	</form>
 </div>
	
    <footer class="footer">
		<p> movie4you © 2016 </p>
    </footer>
    </div> <!-- /container -->
</body>
</html>
