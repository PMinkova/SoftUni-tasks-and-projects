function solve() {
    let input = document.getElementById('input');
    let output = document.getElementById('output');

    let sentences = input.innerHTML.split('.');
    sentences.pop();

    for (let i = 0; i < sentences.length; i += 3) {
        let text = sentences.slice(i, i + 3).join('.');
        let p = document.createElement('p');
        p.innerHTML = text + '.';
        output.appendChild(p);
    }
}
