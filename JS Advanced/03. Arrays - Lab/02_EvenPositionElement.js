function solve(array = []) {
    const isEvenIndex = (_, i) => i % 2 == 0;

    return array
        .slice()
        .filter(isEvenIndex)
        .join(' ');
}

console.log(solve(['20', '30', '40']));
