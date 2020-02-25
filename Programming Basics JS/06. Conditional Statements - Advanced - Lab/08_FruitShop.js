function fruitShop(input) {
    let product = input.shift();
    let dayOfWeek = input.shift();
    let quantity = +input.shift();

    let price = 0;

    if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") {
        if (product == "banana") {
            price = 2.70;
        } else if (product == "apple") {
            price = 1.25;
        } else if (product == "orange") {
            price = 0.90;
        } else if (product == "grapefruit") {
            price = 1.60;
        } else if (product == "kiwi") {
            price = 3.00;
        } else if (product == "pineapple") {
            price = 5.60;
        } else if (product == "grapes") {
            price = 4.20;
        } else {
            price = "error";
        }
    } else if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday") {
        if (product == "banana") {
            price = 2.50;
        } else if (product == "apple") {
            price = 1.20;
        } else if (product == "orange") {
            price = 0.85;
        } else if (product == "grapefruit") {
            price = 1.45;
        } else if (product == "kiwi") {
            price = 2.70;
        } else if (product == "pineapple") {
            price = 5.50;
        } else if (product == "grapes") {
            price = 3.85;
        } else {
            price = "error";
        }
    } else {
        price = "error";
    }

    if (price != "error") {
        price *= quantity;
        console.log(price.toFixed(2));
    } else {
        console.log(price);
    }
}

fruitShop(["apple", "Workday", 2]);