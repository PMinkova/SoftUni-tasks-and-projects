function grades(grade) {
  let result = "";

  if (2.0 <= grade && grade <= 2.99) {
    result = "Fail";
  } else if (3.0 <= grade && grade <= 3.49) {
    result = "Poor";
  } else if (3.5 <= grade && grade <= 4.49) {
    result = "Good";
  } else if (4.5 <= grade && grade <= 5.49) {
    result = "Very good";
  } else if (5.5 <= grade && grade <= 6.0) {
    result = "Excellent";
  }

  return result;
}

console.log(grades(5));
