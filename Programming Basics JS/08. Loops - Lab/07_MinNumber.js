function minNumber(input) {
  let numbersCount = +input.shift();
  let minNumber = Number.MAX_SAFE_INTEGER;
  let counter = 0;

  while (counter < numbersCount) {
    let number = +input.shift();

    if (number < minNumber) {
      minNumber = number;
    }

    counter++;
  }
  console.log(minNumber);
}

minNumber([2, 23, 24]);
