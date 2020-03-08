function createArticle() {
    let article = document.createElement('article');
    let h3 = document.createElement('h3');
    let p = document.createElement('p');

    let input = document.getElementById('createTitle');
    let textarea = document.getElementById('createContent');
    let section = document.getElementById('articles');

    if (input === null || textarea === null || section === null) {
        throw new Error('ERROR');
    }

    if (input.value === '' || textarea.value === '') {
        return;
    }

    debugger;
    h3.innerHTML = input.value;
    p.innerHTML = textarea.value;

    section.appendChild(article);
    article.appendChild(h3);
    article.appendChild(p);

    input.value = '';
    textarea.value = '';
}
