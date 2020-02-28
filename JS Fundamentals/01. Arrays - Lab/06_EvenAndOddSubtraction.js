function evenAndOddSubtraction(array) {
  let evenSum = 0;
  let oddSum = 0;

  for (const number of array) {
    if (number % 2 == 0) {
      evenSum += number;
    } else {
      oddSum += number;
    }
  }

  let difference = evenSum - oddSum;
  console.log(difference);
}

evenAndOddSubtraction([1, 2, 3, 4, 5, 6]);
