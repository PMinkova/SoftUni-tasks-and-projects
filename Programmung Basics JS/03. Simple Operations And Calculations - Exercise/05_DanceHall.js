function danceHall(input){
    let length = Number(input.shift());
    let width = Number(input.shift());
    let wardrobeSide = Number(input.shift());

    let hallArea = length * width;
    let wardrobeArea = wardrobeSide * wardrobeSide;
    let benchArea = hallArea / 10;

    let emptySpace = hallArea - wardrobeArea - benchArea;

    let spaceNeededForOneDancer = 7040 * 0.01 * 0.01;
    let dancersCount = Math.floor(emptySpace / spaceNeededForOneDancer);

    console.log(dancersCount);
}

danceHall([50, 25, 2]);