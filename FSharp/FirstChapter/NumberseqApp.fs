module NumberseqApp

let rec fib n =
    if n <=2 then 1
    else fib (n-1) + fib(n-2)

printfn "%i" (fib 10);;

let x = [|15 .. 20|]
let y = Array.map fib x;;