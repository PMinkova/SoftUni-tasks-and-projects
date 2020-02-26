function cinema(input) {
    let type = input.shift();
    let rowsCount = +input.shift();
    let colsCount = +input.shift();
    let seatsCount = rowsCount * colsCount;
    let income = 0;

    if (type == "Premiere") {
        income = seatsCount * 12.00;
    } else if (type == "Normal") {
        income = seatsCount * 7.50;
    } else if (type == "Discount") {
        income = seatsCount * 5.00;
    }

    console.log(income.toFixed(2) + ' leva');
}

cinema(['Normal', 21, 13]);