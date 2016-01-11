$(document).ready(function() {
	
	// animowany navbar
	var nav = $('.navbar-fixed-top');

	$(window).scroll(function() {
		var scroll = $(window).scrollTop();
		
		if (scroll >= 300) {
			nav.addClass('nav-effect');
		} else {
			nav.removeClass('nav-effect');
		}
	});
	
});
