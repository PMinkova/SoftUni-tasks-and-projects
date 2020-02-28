function fishingBoat(input) {
    let budget = +input.shift();
    let season = input.shift();
    let fishersCount = +input.shift();

    let boatPrice = 0;

    if (season == "Spring") {
        boatPrice = 3000;
    } else if (season == "Summer" || season == "Autumn") {
        boatPrice = 4200;
    } else if (season == "Winter") {
        boatPrice = 2600;
    }

    if (fishersCount <= 6) {
        boatPrice *= 0.9;
    } else if (7 <= fishersCount && fishersCount <= 11) {
        boatPrice *= 0.85;
    } else if (fishersCount >= 12) {
        boatPrice *= 0.75;
    }

    if (fishersCount % 2 == 0 && season != "Autumn") {
        boatPrice *= 0.95;
    }

    let difference = Math.abs(boatPrice - budget);

    if (boatPrice <= budget) {
        console.log(`Yes! You have ${difference.toFixed(2)} leva left.`);
    } else {
        console.log(`Not enough money! You need ${difference.toFixed(2)} leva.`);
    }
}

fishingBoat([3000, 'Summer', 11]);