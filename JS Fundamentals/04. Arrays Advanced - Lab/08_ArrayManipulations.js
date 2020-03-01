function arrayManipulations(array = []) {
  let resultArray = array[0].split(" ").map(Number);

  for (let i = 1; i < array.length; i++) {
    let [command, firstElement, secondElement] = array[i].split(" ");
    let firstNumber = Number(firstElement);
    let secondNumber = Number(secondElement);

    if (command == "Add") {
      resultArray.push(firstNumber);
    } else if (command == "Remove") {
      resultArray = resultArray.filter(x => x !== firstNumber);
    } else if (command == "RemoveAt") {
      resultArray.splice(firstNumber, 1);
    } else if (command == "Insert") {
      resultArray.splice(secondNumber, 0, firstNumber);
    }
  }

  return resultArray.join(" ");
}

let result = arrayManipulations([
  "4 19 2 53 6 43",
  "Add 3",
  "Remove 2",
  "RemoveAt 1",
  "Insert 8 3"
]);

console.log(result);
