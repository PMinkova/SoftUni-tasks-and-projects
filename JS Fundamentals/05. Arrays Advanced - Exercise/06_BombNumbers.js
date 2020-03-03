function bombNumbers(firstArray, secondArray) {
  let numbers = firstArray.slice();
  let [bombNumber, power] = secondArray.slice();

  while (numbers.includes(bombNumber)) {
    let bombIndex = numbers.indexOf(bombNumber);
    let startIndex = Math.max(bombIndex - power, 0);
    numbers.splice(bombIndex, power + 1);
    numbers.splice(startIndex, power);
  }

  let sum = numbers.reduce((a, b) => a + b, 0);
  return sum;
}

console.log(bombNumbers([1, 1, 2, 1, 1, 1, 2, 1, 1, 1], [2, 1]));
