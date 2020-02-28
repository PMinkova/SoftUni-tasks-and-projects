function tailoringShop(input) {
    let tablesCount = Number(input.shift());
    let tableLength = Number(input.shift());
    let tableWidth = Number(input.shift());

    let tableClothArea = (tableLength + 0.30 * 2) * (tableWidth + 0.30 * 2);
    let topperArea = tableLength * 0.5 * tableLength * 0.5;

    let tableClothTotalPrice = tablesCount * tableClothArea * 7;
    let topperTotalPrice = tablesCount * topperArea * 9;
    let totalPriceInUsd = tableClothTotalPrice + topperTotalPrice;
    let totalPriceInBgn = totalPriceInUsd * 1.85;

    console.log(`${totalPriceInUsd.toFixed(2)} USD`)
    console.log(`${totalPriceInBgn.toFixed(2)} BGN`)
}

tailoringShop([
    5, 
    1.00,
    0.50
]);