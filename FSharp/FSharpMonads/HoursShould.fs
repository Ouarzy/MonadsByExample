module HoursShould
open FsUnit.Xunit
open Xunit
open Swensen.Unquote
open Hours

[<Fact>]
let ``proof neutral``() = 
    test <@ add 5 neutralElement = 5 @>

[<Fact>]
let ``proof associative``() = 
    test <@ add 20 (add 5 10) = add (add 20 5) 10 @>

[<Fact>]
let ``proof commutative``() = 
    test <@ add 5 10 = add 10 5 @>
