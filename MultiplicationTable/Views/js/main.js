$(document).ready(function(){

    // Tooltip
    $('[data-toggle="tooltip"]').tooltip(); 

    // Slider
    $('slider').slider({
      orientation: "horizontal",
      range: "min",
      max: 255,
      value: 127
    });
});