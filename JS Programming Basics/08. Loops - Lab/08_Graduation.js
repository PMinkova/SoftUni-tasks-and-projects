function graduation(input) {
  let studentName = input.shift();
  let counter = 0;
  let sum = 0;

  while (counter < 12) {
    let grade = +input.shift();

    if (grade >= 4) {
      sum += grade;
      counter++;
    }
  }

  let averageGrade = sum / 12;

  if (averageGrade >= 4.0) {
    console.log(
      `${studentName} graduated. Average grade: ${averageGrade.toFixed(2)}`
    );
  }
}

graduation([
  "Pesho",
  "4",
  "5.5",
  "6",
  "5.43",
  "4.5",
  "6",
  "5.55",
  "5",
  "6",
  "6",
  "5.43",
  "5"
]);
