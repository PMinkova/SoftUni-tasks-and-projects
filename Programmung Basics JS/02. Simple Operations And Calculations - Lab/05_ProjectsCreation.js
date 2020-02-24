function projectsCreation(input) {
    let architectName = input.shift();
    let projectsCount = Number(input.shift());
    let totalHours = projectsCount * 3;
    console.log(`The architect ${architectName} will need ${totalHours} hours to complete ${projectsCount} project/s.`)
}

projectsCreation(["George", "4"]);