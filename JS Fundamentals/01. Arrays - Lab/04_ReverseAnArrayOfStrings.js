function reverse(array) {
  let reversed = [];

  for (let index in array) {
    reversed.push(array[array.length - index - 1]);
  }

  console.log(reversed.join(" "));
}

reverse(["a", "b", "c", "d", "e"]);
