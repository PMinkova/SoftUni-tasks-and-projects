function solve(data = []) {
    let store = new Map();

    for (let line of data) {
        let [name, price] = line.split(' : ');

        store.set(name, price);
    }

    let initials = new Set();
    Array.from(store.keys()).forEach(k => initials.add(k[0]));

    for (let char of Array.from(initials.keys()).sort()) {
        console.log(char);

        for (let product of Array.from(store.keys()).sort()) {
            if (product.startsWith(char)) {
                console.log(`  ${product}: ${store.get(product)}`);
            }
        }
    }
}

solve([
    'Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10'
]);
