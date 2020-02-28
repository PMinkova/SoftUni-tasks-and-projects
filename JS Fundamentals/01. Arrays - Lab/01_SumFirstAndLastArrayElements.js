function sumFirstAndlastArrayElements(arr) {
  let firtsElement = Number(arr[0]);
  let lastElement = Number(arr[arr.length - 1]);
  sum = firtsElement + lastElement;

  console.log(sum);

  console.log(arr.join(" "));
}

sumFirstAndlastArrayElements(["1", "2", "3"]);
