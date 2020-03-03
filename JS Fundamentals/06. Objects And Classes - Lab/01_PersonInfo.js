function solve(firstName, lastName, age) {
  let person = {
    firstName: firstName,
    lastName: lastName,
    age: age
  };

  for (const key in person) {
    console.log(`${key}: ${person[key]}`);
  }
}

solve("Peter", "Pan", "20");
