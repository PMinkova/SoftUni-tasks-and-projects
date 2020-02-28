function bonusScore(input) {
    let number = +input.shift();
    let bonus = 0;

    if (number <= 100) {
        bonus = 5;
    } else if (100 < number && number <= 1000) {
        bonus = 0.2 * number;
    } else {
        bonus = 0.1 * number;
    }

    if (number % 2 == 0) {
        bonus += 1;
    }

    if (number % 10 == 5) {
        bonus += 2;
    }

    number += bonus;

    console.log(bonus);
    console.log(number);
}

bonusScore([20]);