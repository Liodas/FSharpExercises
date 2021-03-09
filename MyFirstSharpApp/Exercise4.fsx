//The goal of this exercise is to learn about inner functions

let sayHello someValue  =
    let innerFunction number =
        if number > 10 then
            "Isaac"
        elif number > 20 then
            "Fred"
        else
            "Sara"

    let resultOfInner =
        if someValue < 10.
        then innerFunction(5)
        else innerFunction(15)

    "Hello " + resultOfInner

let result = sayHello(10.5)