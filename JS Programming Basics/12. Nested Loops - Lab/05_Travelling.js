function travelling(input) {
  let destination = input.shift();
  let savings = 0;

  while (destination != "End") {
    let vacationPrice = +input.shift();

    while (true) {
      let moneyInput = +input.shift();
      savings += moneyInput;

      if (savings >= vacationPrice) {
        console.log(`Going to ${destination}!`);
        break;
      }
    }

    savings = 0;
    destination = input.shift();
  }
}

travelling([
  "Greece",
  "1000",
  "200",
  "200",
  "300",
  "100",
  "150",
  "240",
  "Spain",
  "1200",
  "300",
  "500",
  "193",
  "423",
  "End"
]);
