function charityCapaign(input) {
    let daysCount = Number(input.shift());
    let confectionersCount = Number(input.shift());
    let cakesCount = Number(input.shift());
    let wafflesCount = Number(input.shift());
    let pancakesCount = Number(input.shift());

    let cakePrice = 45;
    let wafflePrice = 5.80;
    let pancakePrice = 3.20;

    let totalMoney = daysCount * confectionersCount * (cakesCount * cakePrice + wafflesCount * wafflePrice + pancakesCount * pancakePrice);
    let expenses = 1 / 8 * totalMoney;
    totalMoney -= expenses;

    console.log(totalMoney.toFixed(2));
}

charityCapaign([
    20,
    8,
    14,
    30,
    16
])