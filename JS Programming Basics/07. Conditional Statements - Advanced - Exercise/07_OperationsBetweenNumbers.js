function operationsBetweenNumbers(input) {
    let firstNumber = +input.shift();
    let secondNumber = +input.shift();
    let operator = input.shift();

    let result = 0;
    let evenOrodd = "";

    if (secondNumber == 0) {
        console.log(`Cannot divide ${firstNumber} by zero`);
    } else if (operator == "+" || operator == "-" || operator == "*") {
        if (operator == "+") {
            result = firstNumber + secondNumber;
        } else if (operator == "-") {
            result = firstNumber - secondNumber;
        } else if (operator == "*") {
            result = firstNumber * secondNumber;
        }

        if (result % 2 == 0) {
            evenOrodd = "even";
        } else {
            evenOrodd = "odd";
        }

        console.log(`${firstNumber} ${operator} ${secondNumber} = ${result} - ${evenOrodd}`);
    } else if (operator == "/") {
        result = firstNumber / secondNumber;
        console.log(`${firstNumber} / ${secondNumber} = ${result.toFixed(2)}`)
    } else if (operator == "%") {
        result = firstNumber % secondNumber;
        console.log(`${firstNumber} % ${secondNumber} = ${result}`);
    }
}

operationsBetweenNumbers([10, 12, "+"]);