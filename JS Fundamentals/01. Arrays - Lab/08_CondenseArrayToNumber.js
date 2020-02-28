function condenseArray(array) {
  let condensed = [];

  while (array.length > 1) {
    for (let i = 0; i < array.length - 1; i++) {
      condensed.push(array[i] + array[i + 1]);
    }

    array = condensed;
    condensed = [];
  }

  console.log(array[0]);
}

condenseArray[(2, 10, 3)];
