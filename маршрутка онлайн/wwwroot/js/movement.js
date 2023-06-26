document.addEventListener('DOMContentLoaded', function() {
  var cards = document.querySelectorAll('.card'); 

  cards.forEach(function(card) {
    card.style.borderRadius = '25px'; 

    VanillaTilt.init(card, {
      max: 15,
      speed: 400,
      glare: true,
      "max-glare": 0.2
    });
  });
});
