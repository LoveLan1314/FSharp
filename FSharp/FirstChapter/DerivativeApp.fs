module DerivativeApp

let e = 0.001
let Deriative f x = 
    let p = f (x+e)
    let q = f x
    (p-q) / e
let rec MDeriative f n x =
    if n = 0 then f x
    else 
        let p = MDeriative f (n-1) (x+e)
        let q = MDeriative f (n-1) x
        (p-q) / e
let f x = exp (x-1.0/x)
printfn "f=%f, f_1=%f" (f 1.5) (Deriative f 1.5);;

for i=1 to 5 do printf "f_%i=%f, " i (MDeriative f i 1.5);;

let Deriative1 f x = 
    let p = f (x + e)
    let q = f (x - e)
    (p - q) / (2.0*e)

let rec MDeriative1 f n x = 
    if n = 0 then f x
    else 
        let p = MDeriative1 f (n-1) (x+e)
        let q = MDeriative1 f (n-1) (x-e)
        (p-q) / (2.0*e)

printfn "f=%f, f_1=%f" (f 1.5) (Deriative1 f 1.5);;

for i=1 to 5 do printf "f_%i=%f, " i (MDeriative1 f i 1.5);;
