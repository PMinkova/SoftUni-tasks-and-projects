function sumNumbers(input) {
  let command = input.shift();
  let sum = 0;

  while (command != "Stop") {
    let number = +command;
    sum += number;
    command = input.shift();
  }

  console.log(sum);
}

sumNumbers(["3", "1", "2", "3", "Stop"]);
