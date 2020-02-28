function equalArrays(firstArray, secondArray) {
  let areEqual = true;
  let sum = 0;
  let differentIndex = 0;

  for (let i = 0; i < firstArray.length; i++) {
    if (firstArray[i] != secondArray[i]) {
      areEqual = false;
      differentIndex = i;
      break;
    }
    sum += Number(firstArray[i]);
  }

  if (areEqual) {
    console.log(`Arrays are identical. Sum: ${sum}`);
  } else {
    console.log(
      `Arrays are not identical. Found difference at ${differentIndex} index`
    );
  }
}

equalArrays([10, 20, 30], [10, 20, 30]);
