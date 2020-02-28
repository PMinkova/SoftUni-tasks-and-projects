function isEvenOrOdd(input) {
    let number = +input.shift();

    if (number % 2 === 0) {
        console.log("even");
    } else {
        console.log("odd");
    }
}

isEvenOrOdd([2]);