module ParseText

System.Console.WriteLine("请输入一个整数：")
let s = System.Console.ReadLine()
let x = ref 0
let b = System.Int32.TryParse(s, x)
if(b)
    then System.Console.WriteLine("输入的整数为：{0}", !x)
else
    System.Console.WriteLine("输入的整数格式错误");