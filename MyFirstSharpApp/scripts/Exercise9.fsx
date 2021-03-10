// The goal of this exercise is create a function allowing us to print a message on any output stream,
// here 'Console.WriteLine' and 'File.WriteAllText' are used

open System
open System.IO

type Customer =
    {
        Age : int
    }

let printCustomerAge writer customer =
    if customer.Age < 13 then
        writer "Child"
    elif customer.Age < 18 then
        writer "Teenager"
    else
        writer "Adult"

printCustomerAge Console.WriteLine { Age = 2 }

let writeToFile text = File.WriteAllText ("C:/Users/Flavien.Sellet/Documents/exercise9-output.txt", text)
let printToConsole = printCustomerAge writeToFile
printToConsole { Age = 20 }
