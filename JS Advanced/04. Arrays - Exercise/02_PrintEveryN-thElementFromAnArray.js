function solve(array = []) {
    let step = array.pop();

    return array
        .slice()
        .filter((_, i) => i % step === 0)
        .join('\n');
}

console.log(solve(['5', '20', '31', '4', '20', '2']));
