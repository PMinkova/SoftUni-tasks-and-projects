function sorting(array = []) {
  let sortedArray = array.slice().sort((a, b) => b - a);
  let resultArray = [];

  for (let i = 0; i < array.length / 2; i++) {
    let biggestNumber = sortedArray.shift();
    let smallestNumber = sortedArray.pop();

    resultArray.push(biggestNumber);
    resultArray.push(smallestNumber);
  }

  console.log(resultArray.join(" "));
}

sorting([1, 21, 3, 52, 69, 63, 31, 2, 18, 94]);
