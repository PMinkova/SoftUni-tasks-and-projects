function accountBalance(input) {
  let n = +input.shift();
  let counter = 0;
  let balance = 0;

  while (counter < n) {
    let amount = +input.shift();

    if (amount < 0) {
      console.log(`Invalid operation!`);
      break;
    } else {
      console.log(`Increase: ${amount.toFixed(2)}`);
    }
    balance += amount;
    counter++;
  }

  console.log(`Total: ${balance.toFixed(2)}`);
}

accountBalance([3, 5.51, 69.42, 100]);
