function solve(arrayOfStrings = []) {
  let dictionary = {};
  for (let i = 0; i < arrayOfStrings.length; i++) {
    let text = JSON.parse(arrayOfStrings[i]);
    let key = Object.keys(text);
    let value = Object.values(text);
    dictionary[key[0]] = value[0];
  }

  let sortedDictionary = {};

  for (const key of Object.keys(dictionary).sort((a, b) =>
    a.localeCompare(b)
  )) {
    sortedDictionary[key] = dictionary[key];
  }

  for (const term in sortedDictionary) {
    if (sortedDictionary.hasOwnProperty(term)) {
      const definition = sortedDictionary[term];
      console.log(`Term: ${term} => Definition: ${definition}`);
    }
  }
}

solve([
  '{"Coffee":"A hot drink made from the roasted and ground seeds (coffee beans) of a tropical shrub."}',
  '{"Bus":"A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare."}',
  '{"Boiler":"A fuel-burning apparatus or container for heating water."}',
  '{"Tape":"A narrow strip of material, typically used to hold or fasten something."}',
  '{"Microphone":"An instrument for converting sound waves into electrical energy variations which may then be amplified, transmitted, or recorded."}'
]);
