window.addEventListener('load', function() {
  const starWarsDemo = document.querySelector('.starwars-demo');
  const loginForm = document.getElementById('loginForm');

  // Trigger the scrolling effect when clicked
  starWarsDemo.addEventListener('click', function() {
    // Start the scroll animation on click
    starWarsDemo.classList.add('scrolling');

    // After the Star Wars text finishes scrolling, show the login form
    setTimeout(function() {
      loginForm.style.display = 'block';  // Make login form visible
      loginForm.classList.add('scroll'); // Trigger the login scroll animation
    }, 7000); // After 7 seconds, which matches the duration of the scrolling animation
  });

  starWarsDemo.addEventListener('animationend', function() {
    // When the animation ends, add hover effect
    starWarsDemo.classList.add('can-hover');
  });
});
