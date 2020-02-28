function journey(input) {
    let budget = +input.shift();
    let season = input.shift();

    let vacationType;
    let destination;
    let totalPrice = 0;

    if (budget <= 100) {
        destination = "Bulgaria";

        if (season == "summer") {
            totalPrice = 0.3 * budget;
            vacationType = "Camp";
        } else if (season == "winter") {
            totalPrice = 0.7 * budget;
            vacationType = "Hotel";
        }
    } else if (budget > 1000) {
        totalPrice = 0.9 * budget;
        destination = "Europe";
        vacationType = "Hotel";
    } else {
        destination = "Balkans";

        if (season == "summer") {
            totalPrice = 0.4 * budget;
            vacationType = "Camp";
        } else if (season == "winter") {
            totalPrice = 0.8 * budget;
            vacationType = "Hotel";
        }
    }

    console.log(`Somewhere in ${destination}`);
    console.log(`${vacationType} - ${totalPrice.toFixed(2)}`);
}

journey([50, 'summer']);