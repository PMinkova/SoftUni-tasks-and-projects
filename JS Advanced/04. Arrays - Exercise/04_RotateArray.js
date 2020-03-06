function solve(array) {
    let rotations = Number(array.pop());
    rotations %= array.length;

    for (let i = 0; i < rotations; i++) {
        array.unshift(array.pop());
    }

    return array.join(' ');
}

console.log(solve(['1', '2', '3', '4', '2']));
