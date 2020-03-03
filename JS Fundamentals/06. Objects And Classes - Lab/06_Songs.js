function solve(array = []) {
  let inputData = array.slice();
  class Song {
    constructor(type, name, time) {
      this.type = type;
      this.name = name;
      this.time = time;
    }
  }

  let songs = [];
  let numberOfSongs = inputData.shift();

  for (let i = 0; i < numberOfSongs; i++) {
    let [type, name, time] = inputData[i].split("_");
    let currentSong = new Song(type, name, time);
    songs.push(currentSong);
  }

  let typeOfSong = inputData.pop();

  if (typeOfSong === "all") {
    songs.forEach(s => console.log(s.name));
  } else {
    let filterted = songs.filter(s => s.type === typeOfSong);
    filterted.forEach(s => console.log(s.name));
  }
}

solve([
  3,
  "favourite_DownTown_3:14",
  "favourite_Kiss_4:16",
  "favourite_Smooth Criminal_4:01",
  "favourite"
]);
