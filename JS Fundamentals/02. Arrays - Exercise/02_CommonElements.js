function commonElements(firstArray = [], secondArray = []) {
  firstArray.map(element => {
    if (secondArray.includes(element)) {
      console.log(element);
    }
  });
}

commonElements(
  ["Hey", "hello", 2, 4, "Peter", "e"],
  ["Petar", 10, "hey", 4, "hello", "2"]
);
