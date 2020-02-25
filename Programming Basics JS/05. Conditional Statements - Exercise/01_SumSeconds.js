function sumSeconds(input) {
    let timeFirst = +input.shift();
    let timeSecond = +input.shift();
    let timeThird = +input.shift();

    let totalTimeInSeconds = timeFirst + timeSecond + timeThird;
    let minutes = parseInt(totalTimeInSeconds / 60);
    let seconds = totalTimeInSeconds % 60;

    if (seconds < 10) {
        seconds = "0" + seconds;
    }

    console.log(`${minutes}:${seconds}`);
}

sumSeconds([35, 45, 44]);