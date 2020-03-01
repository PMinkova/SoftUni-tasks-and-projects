function negativeOrPositiveNumbers(array) {
  let resultArray = [];
  array.map(x => {
    x < 0 ? resultArray.unshift(x) : resultArray.push(x);
  });

  return resultArray.join("\n");
}

console.log(negativeOrPositiveNumbers([7, -2, 8, 9]));
