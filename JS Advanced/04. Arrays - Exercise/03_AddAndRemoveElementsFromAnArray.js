function solve(arr = []) {
    const commands = {
        add: 'push',
        remove: 'pop'
    };

    let result = arr.reduce((a, b, i) => {
        a[commands[b]](i + 1);
        return a;
    }, []);

    return result.length === 0 ? 'Empty' : result.join('\n');
}

console.log(solve(['remove', 'remove', 'remove']));
