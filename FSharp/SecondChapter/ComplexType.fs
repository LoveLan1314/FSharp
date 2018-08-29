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

type FullName = { First: string; Last: string; }

let fa = {First = "Brown"; Last = "Mike"}
let fb = {First = "小庆"; Last = "张"}

type Specialty = { First: string; Last: string; }
let s: Specialty = {First = "计算机科学"; Last = "程序设计语言"}

let s' = { s with First = "软件工程" };;

let printEng (a:FullName) = printfn "%s %s" (a.First) (a.Last)
let printChn (a:FullName) = printfn "%s%s" (a.Last) (a.First)
printEng fa;;

printChn fb;;

type Vehicle = | Car | Truck | Bus
let v1 = Car;;

System.Console.Write("请选择交通工具：Car，Truck，Bus")
let ch = System.Console.ReadLine().[0]
let v = 
    if ch = 'c' then Car
    else if ch = 't' then Truck
    else Bus

type Vehicle' = 
    | Car of int
    | Truck of int 
    | Bus of int;;

let v2 = Car(6);;

let v3 = Bus(20);;

type School = { Name: string; Department: string; }
type Address = 
    | Common of string
    | Street of string * string * int
    | School of School

let aa1 = Street("朝阳区","建外大街",31);;

let aa2 = School({Name = "北京工业大学"; Department = "数学系"});;

type Route = 
    | Direct of (string * string)
    | Transfer of (string * Route)
let r1 = Direct("北京","厦门");;

let r2 = Transfer("上海",r1);;