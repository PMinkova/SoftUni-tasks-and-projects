function rectangleArea(input) {
    let x1 = Number(input.shift());
    let y1 = Number(input.shift());
    let x2 = Number(input.shift());
    let y2 = Number(input.shift());

    let sideA = Math.abs(x1 - x2);
    let sideB = Math.abs(y1 - y2);

    let area = sideA * sideB;
    let perimeter = 2 * sideA + 2 * sideB;

    console.log(area.toFixed(2));
    console.log(perimeter.toFixed(2));
}

rectangleArea([60, 20, 10, 50])