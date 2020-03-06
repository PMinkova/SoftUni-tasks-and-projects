function solve(arr = []) {
    let delimeter = arr.pop();
    return arr.join(delimeter);
}

console.log(solve(['One', 'Two', 'Three', 'Four', 'Five', '-']));
