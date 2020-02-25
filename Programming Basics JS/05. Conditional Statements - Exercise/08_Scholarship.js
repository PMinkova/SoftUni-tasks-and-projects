function scholarship(input) {
    let incomes = +input.shift();
    let averageGrade = +input.shift();
    let minimalSalary = +input.shift();

    let socialScholarship = 0.35 * minimalSalary;
    let scholarshipForExcellentGrade = averageGrade * 25;

    if (averageGrade > 4.50 && incomes < minimalSalary) {
        if (averageGrade >= 5.50 && scholarshipForExcellentGrade >= socialScholarship) {
            console.log(`You get a scholarship for excellent results ${Math.floor(scholarshipForExcellentGrade)} BGN`);
        } else {
            console.log(`You get a Social scholarship ${Math.floor(socialScholarship)} BGN`);
        }
    } else if (averageGrade >= 5.50) {
        console.log(`You get a scholarship for excellent results ${Math.floor(scholarshipForExcellentGrade)} BGN`);
    } else {
        console.log("You cannot get a scholarship!");
    }
}

scholarship([480.00, 4.60, 450.00]);