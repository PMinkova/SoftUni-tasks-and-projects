function solve(data = []) {
    let names = new Set(data);

    return Array.from(names)
        .sort((a, b) => a.length - b.length || a.localeCompare(b))
        .join('\n');
}

console.log(
    solve([
        'Ashton',
        'Kutcher',
        'Ariel',
        'Lilly',
        'Keyden',
        'Aizen',
        'Billy',
        'Braston'
    ])
);
