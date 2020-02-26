function oldBooks(input) {
  let searchedBook = input.shift();
  let capacity = +input.shift();
  let counter = 0;
  let isFound = false;

  while (counter < capacity) {
    let currentBook = input.shift();

    if (currentBook == searchedBook) {
      isFound = true;
      break;
    }

    counter++;
  }

  if (isFound) {
    console.log(`You checked ${counter} books and found it.`);
  } else {
    console.log(`The book you search is not here!`);
    console.log(`You checked ${counter} books.`);
  }
}

oldBooks(["Troy", "8", "Stronger", "Life Style", "Troy"]);
