module ExprEva

let eva (s : string) = 
    let ss = s.Trim().Split(' ')
    let x = System.Double.Parse ss.[0]
    let y = System.Double.Parse ss.[2]
    match ss.[1] with
    | "+" -> x + y
    | "-" -> x - y
    | "*" -> x * y
    | "/" -> x / y
    | "%" -> x % y
    | "**" -> x ** y
    | _ -> 0.0
printfn "请输入表达式："
let s = System.Console.ReadLine()
if s.Trim().Split(' ').Length < 2 then printfn "表达式格式不正确"
else printfn "=%f" (eva s)