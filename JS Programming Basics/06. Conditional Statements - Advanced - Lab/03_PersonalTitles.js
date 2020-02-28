function personalTitles(input) {
    let age = +input.shift();
    let gender = input.shift();

    if (gender == "m") {
        if (age >= 16) {
            console.log("Mr.");
        } else {
            console.log("Master");
        }
    } else if (gender == "f") {
        if (age >= 16) {
            console.log("Ms.");
        } else {
            console.log("Miss")
        }
    }
}

personalTitles([16, "m"])