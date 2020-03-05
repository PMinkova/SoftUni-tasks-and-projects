function solve(data = []) {
    let products = {};

    for (let i = 0; i < data.length - 1; i += 2) {
        products[data[i]] = Number(data[i + 1]);
    }
    return products;
}

console.log(solve(['Yoghurt', 48, 'Rise', 138, 'Apple', 52]));
