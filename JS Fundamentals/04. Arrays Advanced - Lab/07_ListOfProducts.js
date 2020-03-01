function listOfProducts(array = []) {
  let result = array.slice();
  result.sort();

  for (let i = 0; i < result.length; i++) {
    console.log(`${i + 1}.${result[i]}`);
  }
}

listOfProducts(["Potatoes", "Tomatoes", "Onions", "Apples"]);
