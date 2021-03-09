open System
open System.IO


let countWords (text:string) =
    let array = text.Split ' '
    array.Length.ToString()

let WriteIntoFile text nbWords =
    File.WriteAllText(".\\test", "text = " + text + " | nbWords = " + nbWords)

[<EntryPoint>]
let main argv =
    let text = "This is a test string."
    countWords text |> WriteIntoFile text
    Console.ReadKey() |> ignore
    0 // return an integer exit code

