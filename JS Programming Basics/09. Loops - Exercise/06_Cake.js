function cake(input) {
  let cakeWidth = +input.shift();
  let cakeLength = +input.shift();
  let pieces = cakeLength * cakeWidth;
  let piecesCounter = 0;

  let inputInfo = input.shift();

  while (inputInfo != "STOP") {
    piecesCounter += +inputInfo;

    if (piecesCounter >= pieces) {
      break;
    }

    inputInfo = input.shift();
  }

  let difference = Math.abs(piecesCounter - pieces);

  if (piecesCounter >= pieces) {
    console.log(`No more cake left! You need ${difference} pieces more.`);
  } else {
    console.log(`${difference} pieces are left.`);
  }
}

cake([10, 10, 20, 20, 20, 20, 21]);
