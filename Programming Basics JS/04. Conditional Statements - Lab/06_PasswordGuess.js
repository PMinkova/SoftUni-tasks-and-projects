function passwordGuess(input) {
    let password = input.shift();

    if (password == "s3cr3t!P@ssw0rd") {
        console.log("Welcome")
    } else {
        console.log("Wrong password!")
    }
}

passwordGuess(["querty"]);