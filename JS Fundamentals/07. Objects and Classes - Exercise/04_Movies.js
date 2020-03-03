function solve(movieInfoArr = []) {
  let movieInfo = movieInfoArr.slice();
  let movies = [];
  let currentObject;

  for (let i = 0; i < movieInfo.length; i++) {
    let tokens = movieInfo[i].split(" ");

    if (tokens.includes("addMovie")) {
      tokens.shift();
      let name = tokens.join(" ");
      let currentMoveyInfo = { name: name };
      movies.push(currentMoveyInfo);
    } else if (tokens.includes("directedBy")) {
      let index = tokens.indexOf("directedBy");
      let name = tokens.slice(0, index).join(" ");
      currentObject = movies.find(m => m.name === name);

      if (currentObject) {
        let director = tokens.slice(index + 1).join(" ");
        currentObject.director = director;
      }
    } else if (tokens.includes("onDate")) {
      let index = tokens.indexOf("onDate");
      let name = tokens.slice(0, index).join(" ");
      currentObject = movies.find(m => m.name === name);

      if (currentObject) {
        let date = tokens.slice(index + 1).join(" ");
        currentObject.date = date;
      }
    }
  }

  let filteredMovies = movies.filter(x => Object.keys(x).length == 3);

  for (const movie of filteredMovies) {
    let jsonStr = JSON.stringify(movie);
    console.log(jsonStr);
  }
}

solve([
  "addMovie Fast and Furious",
  "addMovie Godfather",
  "Inception directedBy Christopher Nolan",
  "Godfather directedBy Francis Ford Coppola",
  "Godfather onDate 29.07.2018",
  "Fast and Furious onDate 30.07.2018",
  "Batman onDate 01.08.2018",
  "Fast and Furious directedBy Rob Cohen"
]);
