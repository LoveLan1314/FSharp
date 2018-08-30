module PatternMatch

open System.Linq

let eval x = 
    match x with
    |5 -> "优"
    |4 -> "良"
    |3 -> "中"
    |_ -> "差";;

let y = eval 4;;

let s = Array.map eval [|3; 2; 1; 5|];;

let f x = 
    match x with
    | _ when (x < -1.0) -> 1.0+x
    | _ when (x <= 1.0) -> 0.0
    | _ -> 1.0-x
printfn "f(-2)=%f f(0.5)=%f f(3)=%f" (f -2.5) (f 0.5) (f 3.0);;

let g x y = 
    match x,y with
    | (1,_) -> y
    | (_,1) -> 2*x
    | _ -> 2*x+y
printfn "%i" (g 2 1);;

let check pwd = 
    match pwd with
    | "aaa" | "AAA" -> "密码正确"
    | _ -> "密码错误"

let grade r =
    match r with
    | (s, _, x) when  x >= 70 -> printfn "%s 通过" s
    | (s, '女', _) & (_, _, x) when x >= 60 -> printfn "%s 通过" s
    | (s, _, _) -> printfn "%s 未通过" s

grade ("李明",'男',68);;
grade ("王霞",'女',65);;

type FullName = { First: string; Last: string}
let IsFamily x s = 
    match x with
    | { First = fi; Last = _ } when fi = s -> true
    | _ -> false
let fn = "欧"
let b1 = IsFamily {First = "小强"; Last = "欧"} fn;;
let b2 = IsFamily {First = "强"; Last = "欧阳"} fn;;

type Vehicle = | Car | Truck | Bus
let speed x = 
    match x with
    | Car -> 100
    | Truck -> 60
    | Bus -> 80;;
let mutable v1 = Car
printfn "speed of %O is %i" v1 (speed v1);;
v1 <- Bus
printfn "speed of %O is %i" v1 (speed v1);;

type Length = 
    | Meter of float
    | Millimeter of float
    | Foot of float
    | Inch of float
let ToMM x = 
    match x with
    | Meter x -> x * 1000.0
    | Millimeter x -> x
    | Foot x -> x * 304.8
    | Inch x -> x * 25.4
let l1, l2, l3 = Meter 3.2, Foot 0.5, Inch 8.7
printfn "l1:%.2fmm, l2:%.2fmm, l3:%.2fmm" (ToMM l1) (ToMM l2) (ToMM l3);;

let valid x = 
    match x with
    | Some(1) | Some(2) -> "不及格"
    | Some(x) -> "及格"
    | None -> "缺考"
let x1, x2 = Some(5), None
let y1, y2 = valid x1, valid x2;;