module MutableValues

let mutable x1 = "old value"
let x2 = x1
x1 <- "new value"
printfn "%s" x2;;

let y1 = ref "old value"
let y2 = y1
y1 := "new value"
printfn "%s" !y2;;