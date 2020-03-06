function solve(input) {
    let result = input.reduce((a, b) => {
        if (b > Math.max(...a)) {
            a.push(b);
        }
        return a;
    }, []);

    return result.join('\n');
}

console.log(solve([1, 3, 8, 4, 10, 12, 3, 2, 24]));
