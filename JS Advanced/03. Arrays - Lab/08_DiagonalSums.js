// function solve(input) {
//     let sumFirstDiagonal = 0;
//     let sumSecondDiagonal = 0;

//     for (let i = 0; i < input.length; i++) {
//         sumFirstDiagonal += input[i][i];
//         sumSecondDiagonal += input[i][input.length - i - 1];
//     }

//     return [sumFirstDiagonal, sumSecondDiagonal].join(' ');
// }

function solve(arr) {
    return arr
        .reduce(
            (a, b, i, arr) => {
                a[0] += b[i];
                a[1] += b[arr.length - i - 1];
                return a;
            },
            [0, 0]
        )
        .join(' ');
}

console.log(
    solve([
        [3, 5, 17],
        [-1, 7, 14],
        [1, -8, 89]
    ])
);
