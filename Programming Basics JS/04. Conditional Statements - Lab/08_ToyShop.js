function toyShop(input) {
    let tripPrice = +input.shift();
    let puzzlesCount = +input.shift();
    let dollsCount = +input.shift();
    let teddyBearsCount = +input.shift();
    let minionsCount = +input.shift();
    let trucksCount = +input.shift();

    let totalMoney = puzzlesCount * 2.60 + dollsCount * 3 + teddyBearsCount * 4.10 +
        minionsCount * 8.20 + trucksCount * 2;

    let toysCount = puzzlesCount + dollsCount + teddyBearsCount + minionsCount + trucksCount;

    if (toysCount >= 50) {
        totalMoney *= 0.75;
    }

    totalMoney *= 0.9;
    let difference = Math.abs(totalMoney - tripPrice);

    if (totalMoney >= tripPrice) {
        console.log(`Yes! ${(difference).toFixed(2)} lv left.`);
    } else {
        console.log(`Not enough money! ${difference.toFixed(2)} lv needed.`)
    }
}

toyShop([
    40.8,
    20,
    25,
    30,
    50,
    10
])