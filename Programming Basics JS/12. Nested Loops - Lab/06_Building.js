function building(input) {
  let floors = +input.shift();
  let rooms = +input.shift();

  for (let i = floors; i > 0; i--) {
    for (let j = 0; j < rooms; j++) {
      if (i == floors) {
        process.stdout.write(`L${i}${j} `);
      } else if (i % 2 == 0) {
        process.stdout.write(`O${i}${j} `);
      } else {
        process.stdout.write(`A${i}${j} `);
      }
    }

    console.log();
  }
}

building([6, 4]);
