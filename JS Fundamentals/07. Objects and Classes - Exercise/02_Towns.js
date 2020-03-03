function solve(townData = []) {
  for (let i = 0; i < townData.length; i++) {
    let [town, latitude, longitude] = townData[i].split(" | ");

    let currentTown = {
      town: town,
      latitude: Number(latitude).toFixed(2),
      longitude: Number(longitude).toFixed(2)
    };

    console.log(currentTown);
  }
}

solve(["Sofia | 42.696552 | 23.32601", "Beijing | 39.913818 | 116.363625"]);
