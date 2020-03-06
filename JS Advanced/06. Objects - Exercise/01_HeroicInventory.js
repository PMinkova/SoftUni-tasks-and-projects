function solve(input = []) {
    let heroicData = [];

    for (let line of input) {
        let [name, level, items] = line.split(' / ');
        level = Number(level);
        items = items ? items.split(', ') : []; // if there`s nothing in items -> udefined -> falsy -> empty array!

        let currentHero = { name, level, items };

        heroicData.push(currentHero);
    }

    return (jsonRepresentation = JSON.stringify(heroicData));
}

console.log(
    solve([
        'Isacc / 25 / Apple, GravityGun',
        'Derek / 12 / BarrelVest, DestructionSword',
        'Hes / 1 / Desolator, Sentinel, Antara'
    ])
);
