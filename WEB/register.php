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


	
	

if (isset($_SESSION['fr_name']))
			{
				echo $_SESSION['fr_name'];
				unset($_SESSION['fr_name']);
			}
			
			
		if (isset($_SESSION['e_name']))
			{
				echo '<div class="error">'.$_SESSION['e_name'].'</div>';
				unset($_SESSION['e_name']);
			}	
			

$smarty -> display('register.html');


?>