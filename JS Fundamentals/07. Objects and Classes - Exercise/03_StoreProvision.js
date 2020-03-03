function storeProvision(currentStock = [], orderedStock = []) {
  let store = {};

  for (let i = 0; i < currentStock.length - 1; i += 2) {
    let name = currentStock[i];
    let quantity = Number(currentStock[i + 1]);

    store[name] = quantity;
  }

  for (let i = 0; i < orderedStock.length - 1; i += 2) {
    let newProduct = orderedStock[i];
    let newQuantity = Number(orderedStock[i + 1]);

    if (store.hasOwnProperty(newProduct)) {
      store[newProduct] += newQuantity;
    } else {
      store[newProduct] = newQuantity;
    }
  }

  for (const product in store) {
    console.log(`${product} -> ${store[product]}`);
  }
}

storeProvision(
  ["Chips", "5", "CocaCola", "9", "Bananas", "14", "Pasta", "4", "Beer", "2"],
  ["Flour", "44", "Oil", "12", "Pasta", "7", "Tomatoes", "70", "Bananas", "30"]
);
