function halfSumElement(input) {
  let n = +input.shift();
  let sum = 0;
  let maxNumber = Number.MIN_SAFE_INTEGER;

  for (let i = 0; i < n; i++) {
    let currentNumber = +input.shift();

    if (currentNumber > maxNumber) {
      maxNumber = currentNumber;
    }

    sum += currentNumber;
  }

  if (sum - maxNumber == maxNumber) {
    console.log(`Yes`);
    console.log(`Sum = ${maxNumber}`);
  } else {
    let diff = Math.abs(sum - maxNumber - maxNumber);
    console.log(`No`);
    console.log(`Diff = ${diff}`);
  }
}

halfSumElement([7, 3, 4, 1, 1, 2, 12, 1]);
