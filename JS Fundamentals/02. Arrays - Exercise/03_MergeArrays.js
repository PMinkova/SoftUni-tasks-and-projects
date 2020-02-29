function mergeArrays(firstArray = [], secondArray = []) {
  let resultArray = [];
  let numberToAdd = 0;

  firstArray.map((x, i) => {
    i % 2 == 0
      ? (numberToAdd = +firstArray[i] + +secondArray[i])
      : (numberToAdd = firstArray[i] + secondArray[i]);
    resultArray.push(numberToAdd);
  });

  console.log(resultArray.join(" - "));
}

mergeArrays(["5", "15", "23", "56", "35"], ["17", "22", "87", "36", "11"]);
