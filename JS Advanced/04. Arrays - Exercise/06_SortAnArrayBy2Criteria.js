function solve(arr) {
    return [...arr]
        .sort((a, b) => {
            return a.length - b.length || a.localeCompare(b);
        })
        .join('\n');
}

console.log(solve(['Isacc', 'Theodor', 'Jack', 'Harrison', 'George']));
