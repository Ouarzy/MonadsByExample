module FSharpStarterShould
open FsUnit.Xunit
open Xunit
open Swensen.Unquote
open FSharpStarter

[<Fact>]
let ``Delete invalid pair``() = 
    let invalidSequence = "TA@T!CXYZPOILG"
    test <@ clean invalidSequence = "TATCG" @>
