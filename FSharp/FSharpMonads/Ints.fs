module Ints

open System

let neutralElement = 0
let add x y = x + y 
let minus x y = x - y 


let addOne x = add 1 x

let addFive x = add 5 x

let minusTen x = minus x 10


let addOneAddFiveMinusTen = addOne >> addFive >> minusTen