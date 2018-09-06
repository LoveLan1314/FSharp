module BigNumberOperation

//let x = 8000 * 8000 * 8000;;

let x = 8000L * 8000L * 8000L;;

let y = x * x * x;;

let x': bigint = 8000I * 8000I * 8000I;;

let y' = x' * x' * x';;

let x'' = 7500I * 8000I * 8000I
let b = (x' <= x'');;

let x''' = bigint.Pow(125I,12);;

let x1 = bigint 125;;

let x2 = int64 x1;;

let x3 = bigint.Parse "45000";;

let rec fac n = 
    if n <= 1I then 1I
    else n * fac (n - 1I)
printfn "%O" (fac 30I);;