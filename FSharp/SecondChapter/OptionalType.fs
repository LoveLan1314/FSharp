module OptionalType

let mutable x = Some(50);;

x <- Some(40)
printfn "%i" x.Value;;

x <- None;;
x;;

let x', x'' = Some(8), Some(12);;
if (x.IsSome && x'.IsSome) then
    printfn "%i + %i = %i" x.Value x'.Value (x.Value + x'.Value)
else 
    printfn "None value";;

if(x'.IsSome && x''.IsSome) then
    printfn "%i + %i = %i" x'.Value x''.Value (x'.Value + x''.Value)
else
    printfn "None value";;