module RecFunctions

let rec f x = 
    match x with
    | 100 -> 100
    | _ when (x>100) -> x + f (x-1)
    | _ when (x<100) -> x + f (x+1)

let rec g x =
    match x with
    | 100 -> 100
    | _ when (x>100) -> x + g (x-2)
    | _ when (x<100) -> x + g (x+2)

printf "f(80)=%i f(120)=%i" (f 80) (f 125);;

printf "g(80)=%i g(120)=%i" (g 80) (g 125);;