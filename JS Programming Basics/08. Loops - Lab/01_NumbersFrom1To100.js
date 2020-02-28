function numbersFromOneToOneHundred(input) {
  let number = +input.shift();

  while (number < 1 || 100 < number) {
    console.log(`Invalid number!`);
    number = +input.shift();
  }

  console.log(`The number is: ${number}`);
}

numbersFromOneToOneHundred([101, 120, 179, 20]);
