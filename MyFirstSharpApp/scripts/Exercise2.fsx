//The goal of this exercise is simply to explore the possibilities offered by the 'let' keyword

let text = "Hello World"
let randomValue () = System.Random ()
let func () =
    let value = randomValue ()
    value.Next 15
