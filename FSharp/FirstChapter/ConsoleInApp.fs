module ConsoleInApp

open System

Console.WriteLine "请输入密码："
let s = Console.ReadLine()
if s = "888" then 
    let a = Console.Read()
    Console.WriteLine a
else
    Console.WriteLine "密码错误"