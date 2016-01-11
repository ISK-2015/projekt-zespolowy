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

if ((isset($_SESSION['error_session'])) && ($_SESSION['error_session'])) // błąd logowania
{
	$_SESSION['error_session'] = "Nieprawidłowy login, lub hasło";
}

$smarty -> display('login.html');
?>