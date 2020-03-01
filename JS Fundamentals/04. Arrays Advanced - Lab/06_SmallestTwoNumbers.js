function smallestTwoNumbers(array = []) {
  let result = array
    .sort((a, b) => a - b)
    .slice(0, 2)
    .join(" ");
  console.log(array.join(" "));
  return result;
}

console.log(smallestTwoNumbers([30, 15, 50, 5]));
