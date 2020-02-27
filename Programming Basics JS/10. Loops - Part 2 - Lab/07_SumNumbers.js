function sumNumbers(input) {
  let n = +input.shift();
  let sum = 0;

  for (let i = 0; i < n; i++) {
    let currentNumber = +input.shift();
    sum += currentNumber;
  }

  console.log(sum);
}

sumNumbers([2, 10, 20]);
