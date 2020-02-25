function godzilaVsKong(input) {
    let budget = +input.shift();
    let extrasCount = +input.shift();
    let extrasOutfitPrice = +input.shift();

    let decor = 0.1 * budget;
    let totalOutFitPrice = extrasCount * extrasOutfitPrice;

    if (extrasCount > 150) {
        totalOutFitPrice *= 0.9;
    }

    let expenses = totalOutFitPrice + decor;
    let difference = Math.abs(budget - expenses);

    if (expenses > budget) {
        console.log(`Not enough money!`);
        console.log(`Wingard needs ${(difference).toFixed(2)} leva more.`);
    } else {
        console.log(`Action!`);
        console.log(`Wingard starts filming with ${(difference).toFixed(2)} leva left.`)
    }
}

godzilaVsKong([20000, 120, 55.5])