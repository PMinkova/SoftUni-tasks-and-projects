function solve(n, k) {
    let result = [1];

    for (let i = 0; i < n - 1; i++) {
        result.push(result.slice(-k).reduce((a, b) => a + b));
    }

    return result.join(' ');
}

console.log(solve(6, 3));
