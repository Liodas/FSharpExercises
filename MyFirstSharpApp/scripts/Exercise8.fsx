open System.IO
open System

let writeToFile (date: DateTime) filename text =
    let path = sprintf "C:/Users/Flavien.Sellet/Documents/%s-%s.txt" (date.ToString "yyMMdd") filename
    Console.WriteLine path
    File.WriteAllText(path, text)

let writeToToday = writeToFile DateTime.UtcNow.Date
let writeToTomorrow = writeToFile (DateTime.UtcNow.Date.AddDays 1.)

writeToToday "first-file" "The quick brown fox jumped over the lazy dog"
writeToTomorrow "second-file" "The quick brown fox jumped over the lazy dog"

let writeToTodayHelloWorld = writeToToday "hello-world"
writeToTodayHelloWorld "The quick brown fox jumped over the lazy dog"
