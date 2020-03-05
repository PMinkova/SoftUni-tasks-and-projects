function solve(steps, length, speed) {
    let distanceInMeters = steps * length;
    let speedInMetersPerSec = speed / 3.6;
    let timeInSeconds = Math.round(distanceInMeters / speedInMetersPerSec);
    let timeForRestInSec = parseInt(distanceInMeters / 500) * 60;
    totalTimeInSec = timeInSeconds + timeForRestInSec;
    let hours = Math.floor(totalTimeInSec / 3600);
    let minutes = Math.floor(totalTimeInSec / 60);
    let seconds = totalTimeInSec % 60;

    function addLeadinZero(x) {
        if (0 <= x && x <= 9) {
            x = '0' + x;
        }

        return x;
    }

    hours = addLeadinZero(hours);
    minutes = addLeadinZero(minutes);
    seconds = addLeadinZero(seconds);

    console.log(`${hours}:${minutes}:${seconds}`);
}

solve(4000, 0.6, 5);
solve(2564, 0.7, 5.5);
