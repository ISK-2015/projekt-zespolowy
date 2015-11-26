$(document).ready(function()
{
   Modernizr.load(
   {
       test: Modernizr.input.placeholder,
       nope: ["http://html5form.googlecode.com/svn/trunk/jquery.html5form-1.5-min.js"],
       complete:
           function()
            {
                if (!Modernizr.input.placeholder)
                    $('#myform').html5form();
            }
   }
    );
});