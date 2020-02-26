function walking(input) {
  let goal = 10000;
  let totalSteps = 0;

  while (totalSteps < goal) {
    let inputCommand = input.shift();

    if (inputCommand == "Going home") {
      let stepsToHome = +input.shift();
      totalSteps += stepsToHome;
      break;
    }
    let currentSteps = +inputCommand;
    totalSteps += currentSteps;
  }

  if (totalSteps < goal) {
    let moreStepsCount = goal - totalSteps;
    console.log(`${moreStepsCount} more steps to reach goal.`);
  } else {
    console.log(`Goal reached! Good job!`);
  }
}

walking(["1500", "300", "2500", "3000", "Going home", "200"]);
