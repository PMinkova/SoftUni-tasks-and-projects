function numbersFromNTo1(input) {
  let number = +input.shift();

  for (let i = number; i > 0; i--) {
    console.log(i);
  }
}

numbersFromNTo1([5]);
