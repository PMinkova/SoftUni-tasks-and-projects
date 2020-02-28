function reverse(n, arr) {
  let numbers = arr;
  let newArray = [];

  for (let i = 0; i < n; i++) {
    newArray.push(numbers[n - i - 1]);
  }

  console.log(newArray.join(" "));
}

reverse(3, [10, 20, 30, 40, 50]);
