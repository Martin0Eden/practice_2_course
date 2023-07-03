document.addEventListener('DOMContentLoaded', function() {
    var showFormLink = document.getElementById('show-form_1');
    var closeFormLink = document.getElementById('close-form_1');
    var overlay = document.getElementById('overlay_1');
  
    showFormLink.addEventListener('click', function(event) {
      event.preventDefault();
      overlay.style.display = 'block';
    });
  
    closeFormLink.addEventListener('click', function(event) {
      event.preventDefault();
      overlay.style.display = 'none';
    });
  });

  document.addEventListener('DOMContentLoaded', function() {
    var showFormLink = document.getElementById('show-form_2');
    var closeFormLink = document.getElementById('close-form_2');
    var overlay = document.getElementById('overlay_2');
  
    showFormLink.addEventListener('click', function(event) {
      event.preventDefault();
      overlay.style.display = 'block';
    });
  
    closeFormLink.addEventListener('click', function(event) {
      event.preventDefault();
      overlay.style.display = 'none';
    });
  });
  