open System.IO

let countWords (text:string) =
    let array = text.Split ' '
    array.Length.ToString()

let WriteIntoFile text nbWords =
    File.WriteAllText(".\\test", "text = " + text + " | nbWords = " + nbWords)

let text = "Cette phrase fait 5 mots"
countWords text |> WriteIntoFile text