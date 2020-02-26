function vacation(input) {
  let moneyNeeded = +input.shift();
  let moneyAvailable = +input.shift();

  let daysCount = 0;
  let daysOnlySpending = 0;
  let cannotSaveTheMoney = false;

  while (moneyAvailable < moneyNeeded) {
    let command = input.shift();
    let moneyAmount = +input.shift();

    if (command == "save") {
      moneyAvailable += moneyAmount;
      daysOnlySpending = 0;
    } else if (command == "spend") {
      moneyAvailable -= moneyAmount;
      daysOnlySpending++;

      if (moneyAvailable < 0) {
        moneyAvailable = 0;
      }
    }

    daysCount++;

    if (daysOnlySpending == 5) {
      cannotSaveTheMoney = true;
      break;
    }
  }

  if (cannotSaveTheMoney) {
    console.log(`You can't save the money.`);
    console.log(daysCount);
  } else {
    console.log(`You saved the money for ${daysCount} days.`);
  }
}

vacation([2000, 1000, "spend", 1200, "save", 2000]);
