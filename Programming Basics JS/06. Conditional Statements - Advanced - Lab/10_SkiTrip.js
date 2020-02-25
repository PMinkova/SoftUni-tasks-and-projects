function skiTrip(input) {
    let days = +input.shift();
    let roomType = input.shift();
    let rating = input.shift();
    let nightsCount = days - 1;
    let price = 0;

    if (roomType == "room for one person") {
        price = 18.00 * nightsCount;
    } else if (roomType == "apartment") {
        price = 25.00 * nightsCount;

        if (nightsCount < 10) {
            price *= 0.7;
        } else if (10 <= nightsCount && nightsCount <= 15) {
            price *= 0.65;
        } else if (nightsCount > 15) {
            price *= 0.5;
        }
    } else if (roomType == "president apartment") {
        price = 35.00 * nightsCount;

        if (nightsCount < 10) {
            price *= 0.9;
        } else if (10 <= nightsCount && nightsCount <= 15) {
            price *= 0.85;
        } else if (nightsCount > 15) {
            price *= 0.8;
        }
    }

    if (rating == "positive") {
        price *= 1.25;
    } else {
        price *= 0.9;
    }

    console.log(price.toFixed(2));
}

skiTrip([14, "apartment", "positive"]);