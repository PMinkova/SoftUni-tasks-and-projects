function password(input) {
  let username = input.shift();
  let password = input.shift();
  let inputPassword = input.shift();

  while (inputPassword != password) {
    inputPassword = input.shift();
  }

  console.log(`Welcome ${username}!`);
}

password(["Nakov", "1234", "pass", "1324", "1234"]);
