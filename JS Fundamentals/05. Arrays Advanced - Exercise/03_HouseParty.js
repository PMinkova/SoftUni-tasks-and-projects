function solve(array = []) {
  let guestList = [];

  for (let i = 0; i < array.length; i++) {
    let tokens = array[i].split(" ");
    let name = tokens[0];

    if (tokens.length == 3) {
      if (guestList.includes(name)) {
        console.log(`${name} is already in the list!`);
      } else {
        guestList.push(name);
      }
    } else {
      if (guestList.includes(name)) {
        guestList = guestList.filter(x => x !== name);
      } else {
        console.log(`${name} is not in the list!`);
      }
    }
  }

  return guestList.join("\n");
}

console.log(
  solve([
    "Allie is going!",
    "George is going!",
    "John is not going!",
    "George is not going!"
  ])
);
