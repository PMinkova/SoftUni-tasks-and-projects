function solve(array) {
  for (let i = 0; i < array.length; i++) {
    let currentEmployee = {
      name: array[i],
      personalNumber: array[i].length
    };

    console.log(
      `Name: ${currentEmployee.name} -- Personal Number: ${currentEmployee.personalNumber}`
    );
  }
}

solve([
  "Silas Butler",
  "Adnaan Buckley",
  "Juan Peterson",
  "Brendan Villarreal"
]);
