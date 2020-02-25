function timePlusFifteenMinutes(input){
    let hours = +input.shift();
    let minutes = +input.shift();

    let totalMinutes = hours * 60 + minutes;
    totalMinutes += 15;

    hours = Math.floor(totalMinutes / 60);
    minutes = totalMinutes % 60;

    if(minutes < 10){
        minutes = "0" + minutes;
    }

    if(hours == 24){
        hours = 0;
    }

    console.log(`${hours}:${minutes}`)
}

timePlusFifteenMinutes([1, 46]);