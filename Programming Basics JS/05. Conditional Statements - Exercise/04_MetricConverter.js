function metricConverter(input) {
    let numberToConvert = +input.shift();
    let inputMetric = input.shift();
    let = outputMetric = input.shift();
    let result = 0;

    if (inputMetric == "mm") {
        if (outputMetric == "cm") {
            result = numberToConvert * 0.1;
        } else if (outputMetric == "m") {
            result = numberToConvert * 0.001;
        }
    } else if (inputMetric == "cm") {
        if (outputMetric == "mm") {
            result = numberToConvert * 10;
        } else if (outputMetric == "m") {
            result = numberToConvert * 0.01;
        }
    } else if (inputMetric == "m") {
        if (outputMetric == "cm") {
            result = numberToConvert * 100;
        } else if (outputMetric == "mm") {
            result = numberToConvert * 1000;
        }
    }

    console.log(result.toFixed(3));
}

metricConverter(["150", "m", "cm"]);