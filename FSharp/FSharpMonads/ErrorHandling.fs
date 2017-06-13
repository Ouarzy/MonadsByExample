module ErrorHandling

open System

let stringToInt (s:string) =
    try
        s |> int
    with
        | ex -> failwith "erreur de stringToInt"

let isPositive i = 
    if (i > 0) then
        i
    else
        failwith "i is negative"

let intToString (i: int) = 
    try
        i |> string
    with
    | _ -> failwith "erreur de intToString"

let stringToIntIsPositiveIntToString = stringToInt >> isPositive >> intToString