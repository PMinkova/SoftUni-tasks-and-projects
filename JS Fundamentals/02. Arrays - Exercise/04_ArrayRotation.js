function arrayRotation(array = [], rotations) {
  for (let i = 0; i < rotations; i++) {
    let current = array.shift();
    array.push(current);
  }

  console.log(array.join(" "));
}

arrayRotation([1, 2, 3, 4, 5], 2);
