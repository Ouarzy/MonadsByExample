module ErrorHandling

open System

type Result<'TSuccess, 'TFailure> =
    | Success of 'TSuccess
    | Failure of 'TFailure

let neutralElement x = Success x

let bind f input =
    match input with
    | Success x -> f x
    | Failure y -> Failure y

let stringToInt (s:string) =
    try
        Success (s |> int)
    with
        | _ -> Failure "erreur de stringToInt"

let isPositive i = 
    if (i > 0) then
         Success i
    else
        Failure "i is negative"

let isNegative i = 
    if (i < 0) then
         Success i
    else
        Failure  "i is positive"

let intToString (i: int) = 
    try
        Success ( i |> string)
    with
        | _ -> Failure  "erreur de intToString"

let stringToIntIsPositiveIntToString = stringToInt >> bind isPositive >> bind intToString