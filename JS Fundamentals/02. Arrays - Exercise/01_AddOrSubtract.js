function addOrSubtract(array = []) {
  let resultArray = [];

  array.map((number, index) => {
    number % 2 == 0 ? (number += index) : (number -= index);
    resultArray.push(number);
  });

  let originalSum = array.reduce((a, b) => a + b, 0);
  let resultSum = resultArray.reduce((a, b) => a + b, 0);

  console.log(resultArray);
  console.log(originalSum);
  console.log(resultSum);
}

addOrSubtract([5, 15, 23, 56, 35]);
