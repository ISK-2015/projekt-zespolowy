<?php
/* Smarty version 3.1.29, created on 2016-01-08 00:37:49
  from "/views/index.tpl" */

if ($_smarty_tpl->smarty->ext->_validateCompiled->decodeProperties($_smarty_tpl, array (
  'has_nocache_code' => false,
  'version' => '3.1.29',
  'unifunc' => 'content_568ef6cd380346_03468937',
  'file_dependency' => 
  array (
    '49a39f6a9bdb6cc5554ebedf5f02789301354ab4' => 
    array (
      0 => '/views/index.tpl',
      1 => 1452209741,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_568ef6cd380346_03468937 ($_smarty_tpl) {
?>
<!doctype html>
<html class="no-js" lang="pl">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <title>movie4you - wypożyczalnia dvd/blu-ray</title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">

		<link rel="stylesheet" href="css/bootstrap.css">
        <link rel="stylesheet" href="css/normalize.min.css">
        <link rel="stylesheet" href="css/main.css">

        <?php echo '<script'; ?>
 src="js/vendor/modernizr-2.8.3.min.js"><?php echo '</script'; ?>
>
    </head>
    <body>

        <header>
			<nav class="navbar navbar-default navbar-fixed-top">
				<div class="container">							
					<ul class="nav nav-justified">
						<li><a href="index.html">movie4you</a></li>
						<li><a href="x">cennik</a></li>
						<li><a href="x">katalog</a></li>
						<li><a href="x">szukaj</a></li>
						<li><a href="x">kontakt</a></li>
						<li><a href="x">zaloguj</a></li>
					</ul>
				</div>				
			</nav>
		</header>
		
		<!--<a href="index.html"><img id="logo" src="img/logo.png" alt="logo m4u" /></a>-->
		
		<!--<section id="parallax1" class="parallax1">
		</section>-->
		
		<section id="slider" class="carousel slide" data-ride="carousel">
			<div class="carousel-inner">
				<div class="item center active">
					<img src="img/avengers_age_of_ultron.jpg">
				</div>
				<div class="item center">
					<img src="img/transformers_revenge_of_the_fallen.png">
				</div>
				<div class="item center">
					<img src="img/penguins_of_madagascar.jpg">
				</div>
				<div class="item center">
					<img src="img/the_book_of_eli.jpg">
				</div>
				<div class="item center">
					<img src="img/transformers_age_of_extinction.jpg">
				</div>
				<div class="item center">
					<img src="img/grown_ups_2.jpg">
				</div>
				<div class="item center">
					<img src="img/about_time.jpg">
				</div>
				<div class="item center">
					<img src="img/intouchables.jpg">
				</div>
				<div class="item center">
					<img src="img/man_on_a_ledge.jpg">
				</div>
			</div>
			
			<a class="left carousel-control" href="#slider" role="button" data-slide="prev">
				<span class="glyphicon glyphicon-chevron-left"></span>
			</a>
			<a class="right carousel-control" href="#slider" role="button" data-slide="next">
				<span class="glyphicon glyphicon-chevron-right"></span>
			</a>
			
			<ol class="carousel-indicators">
				<li data-target="#slider" data-slide-to="0" class="active"></li>
				<li data-target="#slider" data-slide-to="1"></li>
				<li data-target="#slider" data-slide-to="2"></li>
				<li data-target="#slider" data-slide-to="3"></li>
				<li data-target="#slider" data-slide-to="4"></li>
				<li data-target="#slider" data-slide-to="5"></li>
				<li data-target="#slider" data-slide-to="6"></li>
				<li data-target="#slider" data-slide-to="7"></li>
				<li data-target="#slider" data-slide-to="8"></li>
				<li data-target="#slider" data-slide-to="9"></li>
		</section>
		
		<section id="price" class="price">
			<div class="container">
				<div class="row">
					<div class="col-md-4">
						<h4 class="text-center">
						2015 - 10zł<br>
						2014-2012 -8zł<br>
						2011-... - 6zł<br>
						</h4>
					</div>
					<div class="col-md-4">
						<h4 class="text-center">
						2015 - 15zł<br>
						2014-2012 -12zł<br>
						2011-... - 9zł<br>
						</h4>
					</div>
					<div class="col-md-4">
						<h4 class="text-center">
						Czas na zwrot: 4 dni<br>
						kara za dzień zwłoki: 2zł<br>
						maksymalna ilośc filmów do wyożyczenia na raz: 3<br>
						zniszczenie płyty: 100zł<br>
						zniszczenie pudełka: 10zł<br>
						długość rezerwacji: 1 dzień<br>
					</div>
				</div>
			</div>
		</section>

		<section id="parallax" class="parallax">
		</section>
		
		<section id="contact" class="contact">
			<h3 class="text-center">Formularz kontaktowy</h3>
				<div class="container">
					<div class="row">
						<div class="col-md-8 col-md-offset-2">
							<form id="form" action="">
								<div class="form-group">
									<input class="form-control" type="text" placeholder="Imię" name="name">
								</div>
								<div class="form-group">
									<input class="form-control" type="e-mail" placeholder="E-mail" name="e-mail">
								</div>
								<div class="form-group">
									<textarea class="form-control" placeholder="Wiadomość" name="message"></textarea>
								</div>
								<div class="form-group">
									<input class="btn btn-default" type="submit" value="Wyślij">
								</div>
							</form>
						</div>
					</div>
				</div>
		</section>
		
		<footer class="footer">
			<center><a href="index.html" class="text-center"><img id="logo" src="img/logo.png" alt="logo m4u" /></a></center>			
		</footer> 
		<p class="text-center" style="padding-bottom: 10px; padding-top: 20px;"> movie4you © 2016 </p>
        <?php echo '<script'; ?>
 src="//ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"><?php echo '</script'; ?>
>
        <?php echo '<script'; ?>
>window.jQuery || document.write('<?php echo '<script'; ?>
 src="js/vendor/jquery-1.11.2.min.js"><\/script>')<?php echo '</script'; ?>
>

		<?php echo '<script'; ?>
 src="js/bootstrap.min.js"><?php echo '</script'; ?>
>
        <?php echo '<script'; ?>
 src="js/main.js"><?php echo '</script'; ?>
>
    </body>
</html>
<?php }
}
