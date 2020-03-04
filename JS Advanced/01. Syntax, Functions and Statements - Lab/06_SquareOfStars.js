function solve(num = 5) {
    let result = '';
    for (let i = 1; i <= num; i++) {
        result += '* '.repeat(num).trim();
        result += '\n';
    }

    return result;
}

console.log(solve(2));
