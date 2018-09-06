module MathFunction

let x = max 3 5;;

let y = min 1.5 -2.5;;

let x1, y1 = abs -2, abs 2.5;;

let a = ceil -3.2;;

let b = floor -3.2;;

let c = truncate 3.2, truncate -3.2;;

let e1 = System.Math.E;;

let e2 = exp 2.0;;

let e3 = 5.0 ** 3.0;;

let z1 = log e2;;

let z2 = log10 e2;;

let z3 = log 0.0;;

let z4 = log10 -0.5;;

let mlog a b = log b / log a
printfn "log_2(5) = %f" (mlog 2.0 5.0);;

printfn "log_2.5(15.625) = %f" (mlog 2.5 15.625);;

let f a b = sin a * cos b + cos a * sin b
let v = f 0.5 0.5, f 0.5 1.0, f 1.0 2.0;;

let d = System.Math.PI;;

printfn "sin180°= %f, cos120°=%f" (sin d) (cos (d/1.5));;

let d1 = System.Math.PI / 6.0
printfn "tan30°= %f, ctan30°= %f" (tan d1) (1.0/(tan d1));;

let d' = asin 2.0;;