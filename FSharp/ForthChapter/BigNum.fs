module BigNum

//let x1 = 3.3e400;;
let x2 = 3.3e40 ** 8.0;;

//#r "FSharp.PowerPack.dll"
let x = 8000N * 8000N * 8000N;

let z = 10000.0 / 3.0;;

let z1 = 10000N / 3N;;

let z2 = 30000N / 9N;;

let z' = bignum.PowN(100N/6N, 10);;

let z'' : bignum = bignum.FromInt 125;;

let z''' = bignum.ToDouble z'';;

let rec pow a b n = 
    let c = a / b
    match n with
    | 0 -> 1N
    | 1 -> c
    | n -> 10N * (pow a b (n-1))
let y1 = pow 14N 3N 160;;
let y2 = pow 6N 7N 160;;
let y3 = y1 * y2;;