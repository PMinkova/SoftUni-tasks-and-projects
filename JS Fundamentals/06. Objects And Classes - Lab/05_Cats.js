function cats(array = []) {
  class Cat {
    constructor(name, age) {
      (this.name = name),
        (this.age = age),
        (this.meow = () => console.log(`${name}, age ${age} says Meow`));
    }
  }

  let cats = [];

  for (let i = 0; i < array.length; i++) {
    let tokens = array[i].split(" ");
    [name, age] = tokens;
    cats.push(new Cat(name, age));
  }

  for (const key in cats) {
    cats[key].meow();
  }
}

cats(["Mellow 2", "Tom 5"]);
