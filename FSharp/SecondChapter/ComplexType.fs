module ComplexType

let a = (1.0, 0.5);;

let b = (170, 65.5);;

let s1 = ("王霞", 158, 51.2);;

let s2 = ("李明", b);;

let x = fst a;;

let y = snd a + snd b;;

let n, h, w = s1;;

//let p, q = s1;;

let name, _, _ = s1;;

let z = (2, 3.14)
printfn "(%i, %f)" (fst z) (snd z);;

printfn "%O" z;;

let a1, a2, a3 = 3, 6, 7.5;;

let maxmin a b c =
    if a>b then
        if b>c then (a,c)
        else if a>c then (a,b)
        else (c,b)
    else
        if b<c then (c,a)
        else if a<c then (b,a)
        else (b,c)
let r = maxmin 2.0 5.0 4.0;;

printfn "max: %f, min: %f" (fst r) (snd r);;