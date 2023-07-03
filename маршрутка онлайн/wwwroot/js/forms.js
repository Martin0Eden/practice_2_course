document.addEventListener('DOMContentLoaded', function() {
    var showFormLink = document.getElementById('show-form_in_taxi');
    var closeFormLink = document.getElementById('close-form_in_taxi');
    var overlay = document.getElementById('overlay_in_taxi');
  
    showFormLink.addEventListener('click', function(event) {
      event.preventDefault();
      overlay.style.display = 'block';
    });
  
    closeFormLink.addEventListener('click', function(event) {
      event.preventDefault();
      overlay.style.display = 'none';
    });
  });

document.addEventListener('DOMContentLoaded', function () {
    var showFormLink = document.getElementById('show-form_up_taxi');
    var closeFormLink = document.getElementById('close-form_up_taxi');
    var overlay = document.getElementById('overlay_up_taxi');

    showFormLink.addEventListener('click', function (event) {
        event.preventDefault();
        overlay.style.display = 'block';
    });

    closeFormLink.addEventListener('click', function (event) {
        event.preventDefault();
        overlay.style.display = 'none';
    });
});

document.addEventListener('DOMContentLoaded', function () {
    var showFormLink = document.getElementById('show-form_del_taxi');
    var closeFormLink = document.getElementById('close-form_del_taxi');
    var overlay = document.getElementById('overlay_del_taxi');

    showFormLink.addEventListener('click', function (event) {
        event.preventDefault();
        overlay.style.display = 'block';
    });

    closeFormLink.addEventListener('click', function (event) {
        event.preventDefault();
        overlay.style.display = 'none';
    });
});

  