function fishTank(input){
    let length = Number(input.shift());
    let width = Number(input.shift());
    let height = Number(input.shift());
    let percentage = Number(input.shift());

    let volume = length * width * height;
    let liters = volume * 0.001;
    let freeSpace = liters - (percentage * 0.01 * liters);

    console.log(freeSpace.toFixed(3))
}

fishTank([105, 77, 89, 18.5])