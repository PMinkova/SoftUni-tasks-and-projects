function firstAndLastKNumbers(array = []) {
  let k = array[0];

  console.log(array.slice(1, k + 1).join(" "));
  console.log(array.slice(array.length - k).join(" "));
}

firstAndLastKNumbers([4, 1, 2, 3, 4, 5, 6]);
