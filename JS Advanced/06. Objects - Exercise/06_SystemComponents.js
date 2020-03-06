function solve(data = []) {
    let register = {};

    for (let line of data) {
        let [system, component, subcomponent] = line.split(' | ');

        if (!register.hasOwnProperty(system)) {
            register[system] = {};
        }

        if (!register[system].hasOwnProperty(component)) {
            register[system][component] = [];
        }

        register[system][component].push(subcomponent);
    }

    let sortedKeys = Object.keys(register).sort(
        (a, b) =>
            Object.keys(register[b]).length - Object.keys(register[a]).length ||
            a.localeCompare(b)
    );

    for (const system of sortedKeys) {
        console.log(system);

        let sortedSubKeys = Object.keys(register[system]).sort(
            (a, b) =>
                Object.keys(register[system][b]).length -
                Object.keys(register[system][a]).length
        );

        for (const component of sortedSubKeys) {
            console.log(`|||${component}`);

            for (const subComponent of register[system][component]) {
                console.log(`||||||${subComponent}`);
            }
        }
    }
}

console.log(
    solve([
        'SULS | Main Site | Home Page',
        'SULS | Main Site | Login Page',
        'SULS | Main Site | Register Page',
        'SULS | Judge Site | Login Page',
        'SULS | Judge Site | Submittion Page',
        'Lambda | CoreA | A23',
        'SULS | Digital Site | Login Page',
        'Lambda | CoreB | B24',
        'Lambda | CoreA | A24',
        'Lambda | CoreA | A25',
        'Lambda | CoreC | C4',
        'Indice | Session | Default Storage',
        'Indice | Session | Default Security'
    ])
);
