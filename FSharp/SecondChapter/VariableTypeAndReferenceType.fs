module VariableTypeAndReferenceType

let mutable x = 5;;

x <- 15
printfn "%i" x;;

type Score = { mutable Math: int; mutable Phys: int; mutable Chem: int}
let s = {Math = 90; Phys = 95; Chem = 80}
s.Math <- 100
printfn "%i %i %i" s.Math s.Phys s.Chem;;

let y = ref 2.25;;
printfn "%f" !y;;

y := !y + 0.2
printfn "%f" !y;;