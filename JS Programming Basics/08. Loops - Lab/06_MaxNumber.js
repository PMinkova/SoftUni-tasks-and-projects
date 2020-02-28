function maxNumber(input) {
  let numbersCount = +input.shift();
  let maxNumber = Number.MIN_SAFE_INTEGER;
  let counter = 0;

  while (counter < numbersCount) {
    let number = +input.shift();

    if (number > maxNumber) {
      maxNumber = number;
    }

    counter++;
  }

  console.log(maxNumber);
}

maxNumber([2, 100, 99]);
