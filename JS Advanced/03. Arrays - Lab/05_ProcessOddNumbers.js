function solve(array = []) {
    return array
        .slice()
        .filter((_, i) => i % 2 !== 0)
        .map(x => x * 2)
        .reverse()
        .join(' ');
}

console.log(solve([10, 15, 20, 25]));
