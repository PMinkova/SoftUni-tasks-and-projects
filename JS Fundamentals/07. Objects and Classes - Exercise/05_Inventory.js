function solve(heroesData = []) {
  let heroes = [];

  for (let i = 0; i < heroesData.length; i++) {
    let [name, level, items] = heroesData[i].split(" / ");
    let itemsList = items
      .split(", ")
      .sort((a, b) => a.localeCompare(b))
      .join(", ");

    let currentHero = {
      name: name,
      level: Number(level),
      items: itemsList
    };

    heroes.push(currentHero);
  }

  heroes.sort((a, b) => a.level - b.level);

  for (const heroe of heroes) {
    console.log(
      `Hero: ${heroe.name}\nlevel => ${heroe.level}\nitems => ${heroe.items}`
    );
  }
}

solve([
  "Isacc / 25 / Apple, GravityGun",
  "Derek / 12 / BarrelVest, DestructionSword",
  "Hes / 1 / Desolator, Sentinel, Antara"
]);
