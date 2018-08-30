module MoreInvoke

let f x = 2.0*x*x + 3.0
let g x = sqrt (x/2.0)
//let y = g (f 3.0);;
let y = 3.0 |> f |> g;;

let f' x = 3.0*x*x - 1.0
let y' = 3.0 |> f' |> g;;

let y'' = 3.0 |> g |> f';;

let h x y = x*x + y*y
let z = g (h 3.0 4.0);;

let z' = h 3.0 4.0 |> g;;

let f1 = fun a b -> a*a + b*b;;

let f2 = fun(a,b) -> a*a + b*b;;

let c1 = f1 3 4;;

let c2 = f2(3, 4);;

let g1 x = x * (x-1)
let y1 = (3, 4) |> f2 |> g1;;

let f3 = f1 3

let c3 = f3 4;;

let a1 = (+) 2 5;;

let a2 = (*) 3 4;;

let muls = (*) 9
let a3 = muls 10;;

let mmuls x = x |> muls |> muls
let a4 = mmuls 11;;