function orders(product, quantity) {
  let price = 0;

  switch (product) {
    case "coffee":
      price = 1.5 * quantity;
      break;
    case "water":
      price = 1.0 * quantity;
      break;
    case "coke":
      price = 1.4 * quantity;
      break;
    case "snacks":
      price = 2.0 * quantity;
      break;
  }

  return price.toFixed(2);
}

let result = orders("coffee", 5);
console.log(result);
