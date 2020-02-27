function oddEvenSum(input) {
  let n = +input.shift();
  let sumEvenPositions = 0;
  let sumOddPositions = 0;

  for (let i = 1; i <= n; i++) {
    let currentNumber = +input.shift();

    if (i % 2 == 0) {
      sumEvenPositions += currentNumber;
    } else {
      sumOddPositions += currentNumber;
    }
  }

  if (sumOddPositions == sumEvenPositions) {
    console.log(`Yes`);
    console.log(`Sum = ${sumOddPositions}`);
  } else {
    let diff = Math.abs(sumEvenPositions - sumOddPositions);
    console.log(`No`);
    console.log(`Diff = ${diff}`);
  }
}

oddEvenSum([4, 10, 50, 60, 20]);
