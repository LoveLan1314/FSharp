module NumericalConversion

let x = 300s
let x' = int x;;

let y = x' * x';;

let x1 = float32 x
let y1 = x1 / 7.0f;;

let x2 = float x1
let y2 = x2 / 7.0;;

let y1' = float y1;;

let y2' = float32 y2;;

let z = sbyte x;;

let z1 = -123s
let z2 = uint16 z1;;

let c1, c2, c3 = 'a', 'A', 'X'
let i1, i2, i3 = int c1, int c2, int c3;;

let chs = (char (i1+1),char (i2+1), char (i3+1));;

let x1' = 203
let s1 = x1'.ToString();;

let x2' = 12.25
let s2 = x2'.ToString();;

let s3 = "302"
let s4 = "25.12"
let x3 = System.Int32.Parse(s3);;
let x4 = System.Double.Parse(s4);;