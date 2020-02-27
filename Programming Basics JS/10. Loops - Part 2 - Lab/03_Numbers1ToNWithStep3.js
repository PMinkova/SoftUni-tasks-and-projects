function numbers1ToNWithStep3(input) {
  let number = +input.shift();

  for (let i = 1; i <= number; i += 3) {
    console.log(i);
  }
}

numbers1ToNWithStep3([10]);
