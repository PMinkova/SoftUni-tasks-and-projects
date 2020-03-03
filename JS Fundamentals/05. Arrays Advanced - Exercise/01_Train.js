function solve(array) {
  let wagons = array[0].split(" ").map(Number);
  let capacity = Number(array[1]);

  for (let i = 2; i < array.length; i++) {
    let commandArgs = array[i].split(" ");
    let peopleCount = 0;

    if (commandArgs[0] == "Add") {
      peopleCount = Number(commandArgs[1]);
      wagons.push(peopleCount);
    } else {
      peopleCount = Number(commandArgs[0]);

      for (let index in wagons) {
        if (wagons[index] + peopleCount <= capacity) {
          wagons[index] += peopleCount;
          break;
        }
      }
    }
  }

  return wagons.join(" ");
}

console.log(
  solve(["32 54 21 12 4 0 23", "75", "Add 10", "Add 0", "30", "10", "75"])
);
