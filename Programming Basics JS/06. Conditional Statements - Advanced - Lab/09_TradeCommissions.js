function tradeComissions(input) {
    let town = input.shift();
    let salesCount = +input.shift();
    let comission = 0;
    let isInvalid = false;

    if (town == "Sofia") {
        if (0 <= salesCount && salesCount <= 500) {
            comission = 0.05 * salesCount;
        } else if (500 < salesCount && salesCount <= 1000) {
            comission = 0.07 * salesCount;
        } else if (1000 < salesCount && salesCount <= 10000) {
            comission = 0.08 * salesCount;
        } else if (10000 < salesCount) {
            comission = 0.12 * salesCount;
        } else {
            isInvalid = true;
        }
    } else if (town == "Varna") {
        if (0 <= salesCount && salesCount <= 500) {
            comission = 0.045 * salesCount;
        } else if (500 < salesCount && salesCount <= 1000) {
            comission = 0.075 * salesCount;
        } else if (1000 < salesCount && salesCount <= 10000) {
            comission = 0.1 * salesCount;
        } else if (10000 < salesCount) {
            comission = 0.13 * salesCount;
        } else {
            isInvalid = true;
        }
    } else if (town == "Plovdiv") {
        if (0 <= salesCount && salesCount <= 500) {
            comission = 0.055 * salesCount;
        } else if (500 < salesCount && salesCount <= 1000) {
            comission = 0.08 * salesCount;
        } else if (1000 < salesCount && salesCount <= 10000) {
            comission = 0.12 * salesCount;
        } else if (10000 < salesCount) {
            comission = 0.145 * salesCount;
        } else {
            isInvalid = true;
        }
    } else {
        isInvalid = true;
    }

    if (isInvalid) {
        console.log("error");
    } else {
        console.log(comission.toFixed(2));
    }
}

tradeComissions(["Varna", 500]);