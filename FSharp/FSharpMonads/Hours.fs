module Hours

open System

open System

let add x y = (x + y) % 24
let minus x y = (x - y) % 24
let neutralElement = 24

let addOne x = add 1 x

let addFive x = add 5 x

let minusTen x = minus x 10


let addOneTwoTimesMinusTen = addOne >> addFive >> minusTen