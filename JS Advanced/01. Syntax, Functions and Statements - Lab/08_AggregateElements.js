function solve(array = []) {
    let sum = array.reduce((a, b) => a + b, 0);
    let invSum = array.reduce((a, b) => a + 1 / b, 0);
    let concat = array.reduce((a, b) => a + b, '');

    console.log(sum);
    console.log(invSum);
    console.log(concat);
}

solve([1, 2, 3]);
