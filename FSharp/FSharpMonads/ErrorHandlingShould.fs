module ErrorHandlingShould
open FsUnit.Xunit
open Xunit
open Swensen.Unquote
open ErrorHandling


[<Fact>]
let ``left identity``() = 
    test <@ bind isPositive (neutralElement 5)  = isPositive 5 @>

[<Fact>]
let ``right identity``() =
    test <@ bind neutralElement (Success 5) = Success 5 @>


[<Fact>]
let ``proof associative``() = 
    let x = Success 5
    let left = bind isPositive (bind isNegative x)
    let right = bind (fun a -> bind isPositive (isNegative a)) x
    test <@ left = right@>


