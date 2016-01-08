<?php
/* Smarty version 3.1.29, created on 2016-01-08 00:52:48
  from "/html/index.html" */

if ($_smarty_tpl->smarty->ext->_validateCompiled->decodeProperties($_smarty_tpl, array (
  'has_nocache_code' => false,
  'version' => '3.1.29',
  'unifunc' => 'content_568efa5032d107_17360351',
  'file_dependency' => 
  array (
    '950a25363eee220f7d8ce234bcc0b349e4ea9072' => 
    array (
      0 => '/html/index.html',
      1 => 1452210735,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_568efa5032d107_17360351 ($_smarty_tpl) {
?>
<!doctype html>
<html class="no-js" lang="pl">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <title>movie4you - wypożyczalnia dvd/blu-ray</title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">

		<link rel="stylesheet" href="html/css/bootstrap.css">
        <link rel="stylesheet" href="html/css/normalize.min.css">
        <link rel="stylesheet" href="html/css/main.css">

        <?php echo '<script'; ?>
 src="html/js/vendor/modernizr-2.8.3.min.js"><?php echo '</script'; ?>
>
    </head>
    <body>

        <header>
			<nav class="navbar navbar-default navbar-fixed-top">
				<div class="container">							
					<ul class="nav nav-justified">
						<li><a href="x">movie4you</a></li>
						<li><a href="x">cennik</a></li>
						<li><a href="x">katalog</a></li>
						<li><a href="x">szukaj</a></li>
						<li><a href="x">kontakt</a></li>
						<li><a href="x">zaloguj</a></li>
					</ul>
				</div>				
			</nav>
		</header>
		
		<section id="slider" class="carousel slide" data-ride="carousel">
			<div class="carousel-inner">
				<div class="item center active">
					<img src="html/img/avengers_age_of_ultron.jpg">
				</div>
				<div class="item center">
					<img src="html/img/penguins_of_madagascar.jpg">
				</div>
				<div class="item center">
					<img src="html/img/the_book_of_eli.jpg">
				</div>
				<div class="item center">
					<img src="html/img/transformers_age_of_extinction.jpg">
				</div>
				<div class="item center">
					<img src="html/img/grown_ups_2.jpg">
				</div>
				<div class="item center">
					<img src="html/img/about_time.jpg">
				</div>
				<div class="item center">
					<img src="html/img/intouchables.jpg">
				</div>
				<div class="item center">
					<img src="html/img/man_on_a_ledge.jpg">
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
			<center><a href="index.html" class="text-center"><img id="logo" src="html/img/logo.png" alt="logo m4u" /></a></center>			
		</footer> 
		<p class="text-center" style="padding-bottom: 10px; padding-top: 20px;"> movie4you © 2016 </p>
        <?php echo '<script'; ?>
 src="//ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"><?php echo '</script'; ?>
>
        <?php echo '<script'; ?>
>window.jQuery || document.write('<?php echo '<script'; ?>
 src="html/js/vendor/jquery-1.11.2.min.js"><\/script>')<?php echo '</script'; ?>
>

		<?php echo '<script'; ?>
 src="html/js/bootstrap.min.js"><?php echo '</script'; ?>
>
        <?php echo '<script'; ?>
 src="html/js/main.js"><?php echo '</script'; ?>
>
    </body>
</html>
<?php }
}
