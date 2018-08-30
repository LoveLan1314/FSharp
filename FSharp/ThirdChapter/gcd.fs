module gcd

let rec gcd(a,b) =
    if a = 1 then b 
    elif b = 1 then a
    elif a = b then b
    else 
        if a > b then gcd(a-b, b)
        else gcd(a, b-a)

printfn "gcd(72, 54) = %i" (gcd(72, 54));;

printfn "gcd(810, 1125) = %i" (gcd(810, 1125));;