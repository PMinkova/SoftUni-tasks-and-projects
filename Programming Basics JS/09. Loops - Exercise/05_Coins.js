function coins(input) {
  let amount = Math.round(input.shift() * 100);
  let coins = 0;
  while (amount > 0) {
    if (amount >= 200) amount -= 200;
    else if (amount >= 100) amount -= 100;
    else if (amount >= 50) amount -= 50;
    else if (amount >= 20) amount -= 20;
    else if (amount >= 10) amount -= 10;
    else if (amount >= 5) amount -= 5;
    else if (amount >= 2) amount -= 2;
    else amount = amount - 1;

    coins++;
  }

  console.log(coins);
}

coins([1.23]);
