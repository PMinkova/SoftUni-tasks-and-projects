function sovle(array) {
    console.log('<table>');

    for (let i = 0; i < array.length; i++) {
        console.log('        <tr>');
        let obj = JSON.parse(array[i]);
        console.log(`                   <td>${obj.name}</td>`);
        console.log(`                   <td>${obj.position}</td>`);
        console.log(`                   <td>${obj.salary}</td>`);
        console.log('        </tr>');
    }

    console.log('</table>');
}

sovle([
    '{"name":"Pesho","position":"Promenliva","salary":100000}',
    '{"name":"Teo","position":"Lecturer","salary":1000}',
    '{"name":"Georgi","position":"Lecturer","salary":1000}'
]);
