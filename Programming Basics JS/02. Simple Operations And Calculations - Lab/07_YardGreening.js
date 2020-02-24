function yardGreening(input) {
    let area = Number(input.shift());
    let price = 7.61 * area;
    let discount = 0.18 * price;
    let totalPrice = price - discount;
    console.log(`The final price is: ${totalPrice.toFixed(2)} lv.`);
    console.log(`The discount is: ${discount.toFixed(2)} lv.`)
}

yardGreening([540])