module Hours

open System


let neutralElement = 24
let add x y = (x + y) % 24
let minus x y = (x - y) % 24

let addOne x = add 1 x

let addFive x = add 5 x

let minusTen x = minus x 10


let addOneAddFiveMinusTen = addOne >> addFive >> minusTen