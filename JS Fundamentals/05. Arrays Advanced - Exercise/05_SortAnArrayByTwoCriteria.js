function solve(array = []) {
  let sorted = array.slice().sort(sortNames);

  function sortNames(a, b) {
    let firstCriteria = a.length - b.length;

    if (firstCriteria === 0) {
      return a.localeCompare(b);
    }

    return firstCriteria;
  }

  console.log(sorted.join("\n"));
}

solve(["alpha", "beta", "gamma"]);
