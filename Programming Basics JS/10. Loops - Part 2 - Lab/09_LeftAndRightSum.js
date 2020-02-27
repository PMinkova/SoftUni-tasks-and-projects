function leftAndRightSum(input) {
  let n = +input.shift();
  let leftSum = 0;
  let rightSum = 0;

  for (let i = 0; i < n; i++) {
    leftSum += +input.shift();
  }

  for (let i = 0; i < n; i++) {
    rightSum += +input.shift();
  }

  if (leftSum == rightSum) {
    console.log(`Yes, sum = ${rightSum}`);
  } else {
    let diff = Math.abs(leftSum - rightSum);
    console.log(`No, diff = ${diff}`);
  }
}

leftAndRightSum([2, 10, 90, 60, 40]);
