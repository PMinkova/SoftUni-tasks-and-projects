function areaOfFigures(input) {
    let figure = input.shift();
    let area = 0;

    switch (figure) {
        case "square": {
            let side = +input.shift();
            area = side * side;
            break;
        }
        case "rectangle": {
            let sideA = +input.shift();
            let sideB = +input.shift();
            area = sideA * sideB;
            break;
        }
        case "circle": {
            let radius = +input.shift();
            area = Math.PI * radius * radius;
            break;
        }
        case "triangle": {
            let side = +input.shift();
            let height = +input.shift();
            area = side * height / 2;
            break;
        }
    }

    console.log(area);
}

areaOfFigures(["square", "5"]);