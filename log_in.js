let array = [];

function login(){
  let username = document.getElementById("username_input");
  let password = document.getElementById("password_input");
  
  array[array.length] = username;
  array[array.length] = password;
}

function updateClock() {
  const now = new Date();
  const hours = String(now.getHours()).padStart(2, '0');
  const minutes = String(now.getMinutes()).padStart(2, '0');
  const seconds = String(now.getSeconds()).padStart(2, '0');
  const clock = document.getElementById('clock');
  if (clock) {
      clock.textContent = `${hours}:${minutes}:${seconds}`;
  }
}

function createClock() {
  const clock = document.createElement('div');
  clock.id = 'clock';
  clock.className = 'clock';
  return clock;
}

function addClockToLoginForms() {
  const leftLoginForm = document.querySelector('#left-full .login-form');
  const rightLoginForm = document.querySelector('#right-full .login-form');

  if (leftLoginForm) {
      const clockLeft = createClock();
      leftLoginForm.insertBefore(clockLeft, leftLoginForm.firstChild);
      console.log('Clock added to Jedi login form');
  }

  if (rightLoginForm) {
      const clockRight = createClock();
      rightLoginForm.insertBefore(clockRight, rightLoginForm.firstChild);
      console.log('Clock added to Sith login form');
  }
}

function initClock() {
  addClockToLoginForms();
  updateClock(); 
  setInterval(updateClock, 1000);
}

window.onload = initClock;

document.addEventListener("keydown", function(event) {
    if (event.key.toLowerCase() === 'h') {
        document.querySelectorAll('.full-screen').forEach(form => {
            form.style.display = (form.style.display === 'none' || form.style.display === '') ? 'flex' : 'none';
        });
    }
});
