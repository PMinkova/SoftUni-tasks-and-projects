function convertToJSON(name, lastName, hairColor) {
  let person = {
    name,
    lastName,
    hairColor: hairColor
  };

  let text = JSON.stringify(person);
  console.log(text);
}

convertToJSON("George", "Jones", "Brown");
