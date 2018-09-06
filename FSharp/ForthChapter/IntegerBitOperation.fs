module IntegerBitOperation

let x = 100uy
let y = ~~~x;;

let x' = 100y
let y' = ~~~x';;

let x1 = 100
let y1 = ~~~x1;;

let x2 = 100ul
let y2 = ~~~x2;;

let a = 2y &&& 14y;;

let a' = -2y &&& -14y;;

let b = 2y ||| 14y;;

let b' = -2y ||| -14y;;

let c = 2y ^^^ 14y;;
let c' = -2y ^^^ -14y;;

let i1 = 1 <<< 10;;

let i2 = 10000 >>> 10;;

let i3 = 1uy <<< 7;;

let i4 = 1y <<< 7;;

let i5 = 1y <<< 10;;