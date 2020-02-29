function solve(numOne, numTwo, numThree) {
  let reuslt = "";

  if (numOne < 0 && numTwo < 0 && numThree < 0) {
    result = "Negative";
  } else if (numOne > 0 && numTwo < 0 && numThree < 0) {
    result = "Positive";
  } else if (numOne > 0 && numTwo > 0 && numThree < 0) {
    result = "Negative";
  } else if (numOne > 0 && numTwo > 0 && numThree > 0) {
    result = "Positive";
  } else if (numOne > 0 && numTwo < 0 && numThree > 0) {
    result = "Negative";
  } else if (numOne < 0 && numTwo < 0 && numThree > 0) {
    result = "Positive";
  } else {
    result = "Positive";
  }

  console.log(result);
}

solve(-5, 0, 1);
