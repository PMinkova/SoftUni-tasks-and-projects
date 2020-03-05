function solve(data = []) {
    const limits = {
        motorway: 130,
        interstate: 90,
        city: 50,
        residential: 20
    };

    let speed = Number(data[0]);
    let area = data[1];
    let areaLimit = limits[area];
    let message = '';

    if (speed <= areaLimit) {
        return;
    } else if (speed <= areaLimit + 20) {
        message = 'speeding';
    } else if (speed <= areaLimit + 40) {
        message = 'excessive speeding';
    } else {
        message = 'reckless driving';
    }

    return message;
}

console.log(solve([21, 'residential']));
