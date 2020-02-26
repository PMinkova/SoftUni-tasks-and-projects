function examPreparation(input) {
  let badGradesCount = +input.shift();
  let badGradesCounter = 0;
  let gradesCounter = 0;
  let gradesSum = 0;
  let lastProblem = "";
  let needABrake = false;

  while (true) {
    let nameOfTheProblem = input.shift();

    if (nameOfTheProblem == "Enough") {
      break;
    }

    lastProblem = nameOfTheProblem;

    let grade = +input.shift();
    gradesCounter++;
    gradesSum += grade;

    if (grade <= 4) {
      badGradesCounter++;
    }

    if (badGradesCount == badGradesCounter) {
      needABrake = true;
      break;
    }
  }

  if (needABrake) {
    console.log(`You need a break, ${badGradesCounter} poor grades.`);
  } else {
    let averageScore = gradesSum / gradesCounter;
    console.log(`Average score: ${averageScore.toFixed(2)}`);
    console.log(`Number of problems: ${gradesCounter}`);
    console.log(`Last problem: ${lastProblem}`);
  }
}

examPreparation([
  "3",
  "Money",
  "6",
  "Strory",
  "4",
  "Spring Time",
  "5",
  "Bus",
  "6",
  "Enough"
]);
