function numberSequence(input) {
  let n = +input.shift();
  let maxNumber = Number.MIN_SAFE_INTEGER;
  let minNumber = Number.MAX_SAFE_INTEGER;

  for (let i = 0; i < n; i++) {
    let currentNumber = +input.shift();

    if (currentNumber > maxNumber) {
      maxNumber = currentNumber;
    }

    if (currentNumber < minNumber) {
      minNumber = currentNumber;
    }
  }

  console.log(`Max number: ${maxNumber}`);
  console.log(`Min number: ${minNumber}`);
}

numberSequence([5, 10, 20, 304, 0, 50]);
