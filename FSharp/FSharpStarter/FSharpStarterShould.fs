module FSharpStarterShould
open FsUnit.Xunit
open Xunit
open Swensen.Unquote
open FSharpStarter

[<Fact>]
let ``add one``() = 
    test <@ addOne 4 = 4 @>
