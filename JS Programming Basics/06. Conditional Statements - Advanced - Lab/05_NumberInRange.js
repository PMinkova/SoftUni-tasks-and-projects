function numberInrange(input){
    let number = +input.shift();

    if(-100 <= number && number <= 100 && number != 0){
        console.log("Yes");
    } else{
        console.log("No");
    }
}

numberInrange([67])