function solve(firstArray, secondArray) {
  [takeCount, deleteCount, searchedNumber] = secondArray;

  let elements = firstArray.slice(0, takeCount);
  elements.splice(0, deleteCount);
  let occurrences = elements.filter(x => x === searchedNumber).length;

  return `Number ${searchedNumber} occurs ${occurrences} times.`;
}

console.log(solve([5, 2, 3, 4, 1, 6], [5, 2, 3]));
