function solve(matrix) {
    let sum = matrix[0].reduce((a, b) => a + b);
    let isMagic = true;

    for (let i = 1; i < matrix.length; i++) {
        if (sum != matrix[i].reduce((a, b) => a + b)) {
            isMagic = false;
            break;
        }
    }

    for (let col = 0; col < matrix[0].length; col++) {
        let sumCol = 0;
        for (let row = 0; row < matrix.length; row++) {
            sumCol += matrix[row][col];
        }

        if (sumCol != sum) {
            isMagic = false;
        }
    }

    return isMagic;
}

console.log(
    solve([
        [4, 5, 6],
        [6, 5, 4],
        [5, 5, 5]
    ])
);
