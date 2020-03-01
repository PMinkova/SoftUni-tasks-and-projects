function processOddNumbers(array) {
  let resultArray = array
    .filter((x, i) => i % 2 == 1)
    .map(x => x * 2)
    .reverse();
  return resultArray.join(" ");
}

console.log(processOddNumbers([10, 15, 20, 25]));
