// The goal of this exercise is to :
// - create a function called 'parse' taking a string as parameter
// - return a tuple from the original string, with the last parameter converted as an integer
// - deconstruct the previously created tuple in 3 different variables

let parse (person: string) =
    let splittedPerson = person.Split ' '
    splittedPerson.[0], splittedPerson.[1], int splittedPerson.[2]

let playername, game, score = parse "Mary Asteroids 2500"
