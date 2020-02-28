function summerOutFit(input) {
    let degrees = +input.shift();
    let partOfTheDay = input.shift();

    let outfit = "";
    let shoes = "";

    if (10 <= degrees && degrees <= 18) {
        if (partOfTheDay == "Morning") {
            outfit = "Sweatshirt";
            shoes = "Sneakers";
        } else if (partOfTheDay == "Afternoon") {
            outfit = "Shirt";
            shoes = "Moccasins";
        } else if (partOfTheDay == "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    } else if (18 < degrees && degrees <= 24) {
        if (partOfTheDay == "Morning") {
            outfit = "Shirt";
            shoes = "Moccasins";
        } else if (partOfTheDay == "Afternoon") {
            outfit = "T-Shirt";
            shoes = "Sandals";
        } else if (partOfTheDay == "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    } else if (degrees >= 25) {
        if (partOfTheDay == "Morning") {
            outfit = "T-Shirt";
            shoes = "Sandals";
        } else if (partOfTheDay == "Afternoon") {
            outfit = "Swim Suit";
            shoes = "Barefoot";
        } else if (partOfTheDay == "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    }

    console.log(`It's ${degrees} degrees, get your ${outfit} and ${shoes}.`);
}

summerOutFit([16, 'Morning']);