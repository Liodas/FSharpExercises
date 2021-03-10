// The goal of this exercise is to
// - Count the number of words in a string
// - Write the result and the initial sentence in a file.

open System.IO

let countWords (text: string) =
    text.Split ' ' |> Array.length

let WriteIntoFile text nbWords =
    File.WriteAllText(".\\test", "text = " + text + " | nbWords = " + nbWords.ToString ())

let text = "This is a test sentence."
countWords text |> WriteIntoFile text
