// The goal of this exercise is to learn about tuples and immutable variables, even if, in this case, it is simple to implement without a tuple

let drive(petrol, distance) =
    if distance > 50 then petrol / 2.0
    elif distance > 25 then petrol - 10.0
    elif distance > 0 then petrol - 1.0
    else petrol

let petrol = 100.0
let firstState = drive(petrol, 55)
let secondState = drive(firstState, 28)
let thirdState = drive(secondState, 3)
let finalState = drive(secondState, 0)
