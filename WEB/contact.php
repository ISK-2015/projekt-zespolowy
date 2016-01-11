<?php
session_start();
require_once('lib/Smarty.class.php');
$smarty = new Smarty();
$smarty -> template_dir = 'html';
$smarty -> compile_dir = 'temp';
$smarty -> cache_dir = 'cache';
$smarty -> display('contact.html');
?>