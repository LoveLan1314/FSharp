module FunctionBase

let f1 = fun x -> x * x - 2 * x
let f2 x = 
    let x' = x - 2
    x * x'

let g1 = fun x y -> x*(x+1) + y*(y-1);;
let g2 x y z = 1.0 + x*x + y*y + z*z;;

let mutable a, b = 6, 9
let vChange x y =
    let t = x
    let x = x + y
    let y = y - t
    (x, y)
let z1 = (vChange a b);;

let z1' = (a, b);;

let a1, b1 = ref 6, ref 9
let rChange ref x y =
    let t = !x
    x := !x + !y
    y := !y - t
    (x, y)
let z2 = (rChange ref a1 b1);;

let z2' = (!a1, !b1);;

let rChange' x ref y = 
    let t = x
    let x = x + !y
    y := !y - t
    (x, y)
let a2, b2 = 6, ref 9
let z3 = (rChange' a2 ref b2);;
let z3' = (a2, !b2);

let getsec = fun() ->
    let now = System.DateTime.Now
    now.Second
let x = getsec;;
let y = getsec();;

let getsec1() = System.DateTime.Now.Second;;

let getsec2 = System.DateTime.Now.Second;;

let pt() = 
    let now = System.DateTime.Now
    printf "%i月%i日" now.Month now.Day;;
pt();;

let db ref x = 
    x := !x * 2
    ();;

ignore(getsec());;

let mutable z = 100
let h1 x y = 
    let mutable z = x * y
    z <- z-1
    printfn "(local)z = %i" z
    z * z
printfn "h1(3,7) = %i" (h1 3 7);;
printfn "(global)z = %i" z;;

let h2 x y = 
    let x = x * y
    let x = x - 1
    printfn "x = %i" x
    x * x
printfn "h2(3,4) = %i" (h2 3 4);;

let mutable x1 = 10
let h3 x = 
    x1 <- x1 + x
h3 5
printfn "x1 = %i" x1;;