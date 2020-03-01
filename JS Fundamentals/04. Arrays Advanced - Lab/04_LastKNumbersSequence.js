function lastKNumbersSequence(n, k) {
  let array = [];
  array[0] = 1;

  for (let i = 1; i < n; i++) {
    let startIndex = Math.max(0, i - k);
    let ellementToPush = array.slice(startIndex);
    let sum = ellementToPush.reduce((a, b) => a + b);
    array.push(sum);
  }

  return array.join(" ");
}

console.log(lastKNumbersSequence(6, 3));
