// function solve(arr = []) {
//     const actions = {
//         true: 'unshift',
//         false: 'push'
//     };

//     let result = [];

//     for (let i = 0; i < arr.length; i++) {
//         result[actions[arr[i] < 0]](arr[i]);
//     }
//     return result;
// }

function solve(arr = []) {
    const actions = {
        true: 'unshift',
        false: 'push'
    };

    return arr.reduce((result, x) => {
        result[actions[x < 0]](x);
        return result;
    }, []);
}

console.log(solve([3, -2, 0, -1]));
