document.addEventListener('DOMContentLoaded', function() {
  var showFormLinks = document.querySelectorAll('.show-form');
  var closeFormLinks = document.querySelectorAll('.close-form');
  var overlays = document.querySelectorAll('.overlay');

  showFormLinks.forEach(function(link, index) {
    link.addEventListener('click', function(event) {
      event.preventDefault();
      overlays[index].style.display = 'block';
    });
  });

  closeFormLinks.forEach(function(link, index) {
    link.addEventListener('click', function(event) {
      event.preventDefault();
      overlays[index].style.display = 'none';
    });
  });
});
