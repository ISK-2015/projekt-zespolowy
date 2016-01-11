<?php

session_start();

if ((!isset($_SESSION['online'])) && ($_SESSION['online']==true)) // jeœli NIE jest zalogowany, przenosi na index.php
{
	header('Location: index.php');
	exit();
}

require_once('lib/Smarty.class.php');
$smarty = new Smarty();
$smarty -> template_dir = 'html';
$smarty -> compile_dir = 'temp';
$smarty -> cache_dir = 'cache';
$smarty -> display('user.html');
?>