function solve(input = []) {
    let juices = {};
    let bottles = {};

    for (let line of input) {
        [fruit, quantity] = line.split(' => ');
        quantity = Number(quantity);

        if (!juices.hasOwnProperty(fruit)) {
            juices[fruit] = 0;
        }
        juices[fruit] += quantity;

        if (juices[fruit] >= 1000) {
            let bottlesCount = Math.trunc(juices[fruit] / 1000);
            bottles[fruit] = bottlesCount;
        }
    }

    for (let juice in bottles) {
        console.log(`${juice} => ${bottles[juice]}`);
    }
}

solve([
    'Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549'
]);
