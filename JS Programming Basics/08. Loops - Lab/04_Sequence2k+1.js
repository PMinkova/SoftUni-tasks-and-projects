function sequence(input) {
  let number = Number(input.shift());
  let k = 1;

  while (k <= number) {
    console.log(k);
    k = 2 * k + 1;
  }
}

sequence([3]);
