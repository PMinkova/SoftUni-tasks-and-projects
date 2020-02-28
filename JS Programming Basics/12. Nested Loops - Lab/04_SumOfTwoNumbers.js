function sumOfTwoNumbers(input) {
  let start = +input.shift();
  let end = +input.shift();
  let magicNumber = +input.shift();
  let counter = 0;
  let isFound = false;
  let firstNumber = 0;
  let secondNumber = 0;

  for (let i = start; i <= end; i++) {
    for (let j = start; j <= end; j++) {
      counter++;

      if (i + j == magicNumber) {
        isFound = true;
        firstNumber = i;
        secondNumber = j;
        break;
      }
    }

    if (isFound) {
      break;
    }
  }

  if (isFound) {
    console.log(
      `Combination N:${counter} (${firstNumber} + ${secondNumber} = ${magicNumber})`
    );
  } else {
    console.log(`${counter} combinations - neither equals ${magicNumber}`);
  }
}

sumOfTwoNumbers([88, 888, 1000]);
