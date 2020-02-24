function petShop(input) {
    let dogsCount = Number(input.shift());
    let otherAnimalsCount = Number(input.shift());

    let totalAmount = (dogsCount * 2.50 + otherAnimalsCount * 4.0);
    console.log(totalAmount.toFixedog(2) + " lv.");
}

petShop(["5", "4"])