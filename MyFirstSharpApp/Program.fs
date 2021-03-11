open Domain
open Operations

[<EntryPoint>]
let main argv =
    let customer = { FirstName = "Flavien"; LastName = "Sellet" ; Age = 24 }

    if customer |> isOlderThan 18 then
        printf "%s %s is an adult" customer.FirstName customer.LastName
    else
        printf "%s %s is a child" customer.FirstName customer.LastName

    0