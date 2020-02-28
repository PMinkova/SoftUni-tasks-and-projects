function newHouse(input) {
    let type = input.shift();
    let flowersCount = +input.shift();
    let budget = +input.shift();

    let totalPrice = 0;

    if (type == "Roses") {
        totalPrice = flowersCount * 5;
        if (flowersCount > 80) {
            totalPrice *= 0.9;
        }
    } else if (type == "Dahlias") {
        totalPrice = flowersCount * 3.80;
        if (flowersCount > 90) {
            totalPrice *= 0.85;
        }
    } else if (type == "Tulips") {
        totalPrice = flowersCount * 2.80;
        if (flowersCount > 80) {
            totalPrice *= 0.85;
        }
    } else if (type == "Narcissus") {
        totalPrice = flowersCount * 3.00;
        if (flowersCount < 120) {
            totalPrice *= 1.15;
        }
    } else if (type == "Gladiolus") {
        totalPrice = flowersCount * 2.50;
        if (flowersCount < 80) {
            totalPrice *= 1.2;
        }
    }

    let difference = Math.abs(totalPrice - budget);

    if (totalPrice <= budget) {
        console.log(`Hey, you have a great garden with ${flowersCount} ${type} and ${difference.toFixed(2)} leva left.`);
    } else {
        console.log(`Not enough money, you need ${difference.toFixed(2)} leva more.`);
    }
}

newHouse(['Roses', '55', '250']);