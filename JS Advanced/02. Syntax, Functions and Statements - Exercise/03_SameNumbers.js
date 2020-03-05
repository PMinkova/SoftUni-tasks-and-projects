function solve(arr = []) {
    let numbers = arr
        .toString()
        .split('')
        .map(Number);

    let result = true;

    for (let i = 0; i < numbers.length - 1; i++) {
        if (numbers[i] !== numbers[i + 1]) {
            result = false;
            break;
        }
    }

    let sum = numbers.reduce((a, b) => a + b, 0);

    console.log(result);
    console.log(sum);
}

solve(1234);
solve(2222222);
