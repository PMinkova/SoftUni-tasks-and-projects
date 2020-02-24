function greaterNumber(input) {
    let firstNumber = Number(input.shift());
    let secondNumber = Number(input.shift());

    if (firstNumber > secondNumber) {
        console.log(firstNumber);
    } else {
        console.log(secondNumber);
    }
}

greaterNumber([5, 3]);