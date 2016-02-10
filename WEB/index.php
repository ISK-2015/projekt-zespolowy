<?php
session_start();
if ((isset($_SESSION['online'])) && ($_SESSION['online']==true)) // dodaje opcje wylogowania
{
	$_SESSION['logout'] = '<a href="logout.php">wyloguj sie</a>';
}

require_once('lib/Smarty.class.php');
$smarty = new Smarty();
$smarty -> template_dir = 'html';
$smarty -> compile_dir = 'temp';
$smarty -> cache_dir = 'cache';





$smarty -> display('index.html');
?>