module NumericComparison

let x = 2 * 5
let b = (x = 10);;

printf "%b, %b" (x < 10) (x <= 10);;

let y1 = 1.0 / 0.0;;

let b1 = (y1 <> (2.0 / 0.0));;

let y2 = 0.0 / 0.0;;

let b2 = (y2 = nan), (y2 <> nan);;

let b3 = (y2 < nan), (y2 <= nan), (y2 > nan), (y2 >= nan);;

let z1 = (3, 4)
printfn "%b" (z1 = (4, 3));;

printfn "%b" (z1 <> (3, 3));;

let z2 = (3, 3, 5)
let z3 = (3, 3, 6)
let z4 = (3, 4, 5)
printfn "%b, %b" (z2 < z3) (z3 < z4);;