function alcoholMarket(input) {
    let whiskeyPrice = Number(input.shift());
    let beerLiters = Number(input.shift());
    let wineLiters = Number(input.shift());
    let schnappsLiters = Number(input.shift());
    let whiskeyLiters = Number(input.shift());

    let schnappsPricePerLiter = 0.5 * whiskeyPrice;
    let schnappsPrice = schnappsPricePerLiter * schnappsLiters;
    let winePrice = wineLiters * (0.6 * schnappsPricePerLiter);
    let beerPrice = beerLiters * (0.2 * schnappsPricePerLiter);

    let totalPrice = whiskeyPrice * whiskeyLiters + schnappsPrice + beerPrice + winePrice;

    console.log(totalPrice.toFixed(2));
}

alcoholMarket([
    50,
    10,
    3.5,
    6.5,
    1
])