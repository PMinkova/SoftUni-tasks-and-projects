function growingWord() {
    let p = document.getElementsByTagName('p')[2];

    if (p.style.color === '' && p.style.fontSize === '') {
        p.style.color = 'blue';
        p.style.fontSize = '2px';
    } else if (p.style.color === 'blue') {
        p.style.color = 'green';
        p.style.fontSize = parseInt(p.style.fontSize) * 2 + 'px';
    } else if (p.style.color === 'red') {
        p.style.color = 'blue';
        p.style.fontSize = parseInt(p.style.fontSize) * 2 + 'px';
    } else if (p.style.color === 'green') {
        p.style.color = 'red';
        p.style.fontSize = parseInt(p.style.fontSize) * 2 + 'px';
    }
}
