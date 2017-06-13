module ErrorHandlingShould
open FsUnit.Xunit
open Xunit
open Swensen.Unquote
open ErrorHandling

[<Fact>]
let ``string to int is positive int to string``() = 
    test <@ stringToIntIsPositiveIntToString "5" = "5" @>

[<Fact>]
let ``string to int is positive int to string fail``() = 
    test <@ stringToIntIsPositiveIntToString "-3" = ? @>
