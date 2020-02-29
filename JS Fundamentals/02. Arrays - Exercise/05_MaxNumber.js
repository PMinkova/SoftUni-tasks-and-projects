function maxNumber(array = []) {
  let resultArray = [];

  for (let i = 0; i < array.length; i++) {
    let currentNumber = array[i];
    let isBigger = true;

    for (let j = i + 1; j < array.length; j++) {
      let nextNumber = array[j];

      if (currentNumber <= nextNumber) {
        isBigger = false;
        break;
      }
    }

    if (isBigger) {
      resultArray.push(currentNumber);
    }
  }

  console.log(resultArray.join(" "));
}

maxNumber([41, 41, 34, 20]);
