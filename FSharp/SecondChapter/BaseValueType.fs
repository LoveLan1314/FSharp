module File1

let b = true
printfn "%b" b;;

let b1 = true
let b2 = not b1;;

let g a b = (a || b) && not (a && b)
printf "%b" (g b1 b2);;

let i1 = 300;;

let i2 = 300s;;

let i3 = 300 - 200;;

let i4 = -i3;;

let i5 = 300 / 200;;

let i6 = 300 % 200;;

//let i7 = 128y;;

let i8 = 127y + 1y;;

let i9 = 300us * 300us;;

open Microsoft.FSharp.Core.Operators.Checked
let i10 = 127y + 1y;;
let i11 = 300us * 300us;;

let f1 = 1.0f;;

let d1 = 3.14;;

let m1 = 0.25M;;

let x = 6.0 % 2.5;;

let y = 7.5 % 3.0;;

let f2 = 0.4e12 + 1.5e11;;

let f3 = 0.4e12 * 1.5e11;;

let z = 1000.0 / 0.3
printfn "%f" z;;

printfn "%.3f" z;;

printfn "%e" z;;

printfn "%.2e" z;;

let z1 = 97.5 + infinity;;  // 一般数加上infinity仍是infinity

let z2 = 1.0 - z1;;   // 一般数减去infinity仍是infinity

let z3 = -2.0 * z2;;    // 一般数乘以infinity也是infinity，符合一般乘法规则

let z4 = -2.0 / -infinity;; // 一般数除以infinity为0

let z5 = 5.0 / 0.0;;

let z6 = 0.0 / 0.0;;

let f x y = 
    if x > 0.0 && x <= 1.0 then (1.0 - x) / x
    else nan

let c = 'a';;

let s = "apple";;

let s' = "微软Office";;

printfn "%s" "C:\\Program Files\\JOS\\版权声明.txt\n\t\"UNMSG\"是一款完全免费的局域网即时通信工具\v可通过邮件注册。";;

let s1 = "师范大学"
let c1 = s1.[3];;

let s2 = "本科生"
let s3 = s1 + " " + s2;;