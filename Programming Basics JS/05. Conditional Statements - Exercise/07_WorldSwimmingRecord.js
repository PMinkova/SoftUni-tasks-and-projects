function worldSwimmingRecord(input) {
    let worldRecordInSeconds = +input.shift();
    let distanceInMeters = +input.shift();
    let timeInSecondsForOneMeterSwimmed = +input.shift();

    let timeLost = parseInt(distanceInMeters / 15) * 12.5;
    let totalTime = distanceInMeters * timeInSecondsForOneMeterSwimmed + timeLost;

    if (totalTime < worldRecordInSeconds) {
        console.log(`Yes, he succeeded! The new world record is ${(totalTime).toFixed(2)} seconds.`)
    } else {
        let secondsSlower = totalTime - worldRecordInSeconds;
        console.log(`No, he failed! He was ${(secondsSlower).toFixed(2)} seconds slower.`)
    }
}

worldSwimmingRecord([10464, 1500, 20]);