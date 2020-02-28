function hotelRoom(input) {
    let month = input.shift();
    let nightsCount = +input.shift();
    let priceForStudio = 0;
    let priceForApartment = 0;

    if (month == "May" || month == "October") {
        priceForApartment = 65 * nightsCount;
        priceForStudio = 50 * nightsCount;

        if (nightsCount > 14) {
            priceForStudio *= 0.7;
            priceForApartment *= 0.9;
        } else if (nightsCount > 7) {
            priceForStudio *= 0.95;
        }
    } else if (month == "June" || month == "September") {
        priceForApartment = nightsCount * 68.7;
        priceForStudio = nightsCount * 75.2;

        if (nightsCount > 14) {
            priceForStudio *= 0.8;
            priceForApartment *= 0.9;
        }
    } else if (month == "July" || month == "August") {
        priceForApartment = nightsCount * 77;
        priceForStudio = nightsCount * 76;

        if (nightsCount > 14) {
            priceForApartment *= 0.9;
        }
    }

    console.log(`Apartment: ${priceForApartment.toFixed(2)} lv.`);
    console.log(`Studio: ${priceForStudio.toFixed(2)} lv.`);
}

hotelRoom(["May", 15]);