/*=============================================================
    Authour URL: www.designbootstrap.com
    
    http://www.designbootstrap.com/

    License: MIT

    http://opensource.org/licenses/MIT

    100% Free To use For Personal And Commercial Use.

    IN EXCHANGE JUST TELL PEOPLE ABOUT THIS WEBSITE
   
========================================================  */

$(document).ready(function () {

/*====================================
SCROLLING SCRIPTS
======================================*/

/*====================================
SLIDER SCRIPTS
======================================*/


$('#carousel-slider').carousel({
interval: 2000 //TIME IN MILLI SECONDS
});


/*====================================
VAGAS SLIDESHOW SCRIPTS
======================================*/
$.vegas('slideshow', {
backgrounds: [
{ src: '/Content/img/1.jpg', fade: 1000, delay: 9000 },
{ src: '/Content/img/2.jpg', fade: 1000, delay: 9000 },
{ src: '/Content/img/3.jpg', fade: 1000, delay: 9000 },
{ src: '/Content/img/4.jpg', fade: 1000, delay: 9000 },
{ src: '/Content/img/5.jpg', fade: 1000, delay: 9000 },
{ src: '/Content/img/6.jpg', fade: 1000, delay: 9000 },
]
})('overlay', {
/** SLIDESHOW OVERLAY IMAGE **/
src: '/Content/js/vegas/overlays/06.png' // THERE ARE TOTAL 01 TO 15 .png IMAGES AT THE PATH GIVEN, WHICH YOU CAN USE HERE
});
 



});
