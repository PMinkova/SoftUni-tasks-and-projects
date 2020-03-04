function solve(x, y) {
    let sum = 0;

    for (let i = x; i <= y; i++) {
        sum += Number(i);
    }

    return sum;
}

console.log(solve('1', '5'));
