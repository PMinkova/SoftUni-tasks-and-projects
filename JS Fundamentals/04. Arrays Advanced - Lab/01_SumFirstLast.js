function sumFirstLast(array) {
  let firstNumber = Number(array[0]);
  let lastNumber = Number(array[array.length - 1]);

  return firstNumber + lastNumber;
}

console.log(sumFirstLast(["20", "30", "40"]));
