function graduation(input) {
  let studentName = input.shift();
  let counter = 0;
  let gradeSum = 0;
  let isExcludet = false;

  while (counter < 12) {
    let grade = +input.shift();

    if (grade >= 4) {
      gradeSum += grade;
      counter++;
    } else if (isExcludet == false) {
      isExcludet = true;
    } else {
      break;
    }
  }

  let averageGrade = gradeSum / 12;

  if (isExcludet) {
    console.log(`${studentName} has been excluded at ${counter + 1} grade`);
  } else {
    console.log(
      `${studentName} graduated. Average grade: ${averageGrade.toFixed(2)}`
    );
  }
}

graduation(["Mimi", "5", "6", "5", "6", "5", "6", "6", "2", "3"]);
