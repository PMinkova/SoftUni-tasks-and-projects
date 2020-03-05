function solve(array) {
    let input = array.slice();
    let y = Number(input.shift());

    const operations = {
        chop: x => x / 2,
        dice: x => Math.sqrt(x),
        spice: x => x + 1,
        bake: x => x * 3,
        fillet: x => x * 0.8
    };

    input.map(x => console.log((y = operations[x](y))));
}

solve(['32', 'chop', 'chop', 'chop', 'chop', 'chop']);
solve(['9', 'dice', 'spice', 'chop', 'bake', 'fillet']);
