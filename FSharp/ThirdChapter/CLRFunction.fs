module CLRFunction

printfn "%i年级%i班" 5 3
System.Console.WriteLine("{0}年级{1}班", 5, 3);

let p = System.Diagnostics.Process.Start("Notepad","C:\\Program.fs");;

let runfile app file = 
    System.Diagnostics.Process.Start(app, file)
let p' = runfile "Notepad" "C:\\Program.fs";;
let runNotepad = runfile "Notepad"
let p'' = runNotepad "C:\\Program.fs";;

let s1 = "Visual Studio 2010"
let x = s1.Length;;

printfn "%s, %s" (s1.ToUpper()) (s1.ToLower());;

let s2 = "清华大学出版社"
let s3 = s2.Substring(2);;
let s4 = s2.Substring(0,4);;

printfn "%s" (s2.Remove(4));;

printfn "%s" (s2.Remove(2,2));;

printfn "%s" (s2.Insert(4,"~").Insert(2, " "));;

let s5 = "Happy Students Have Student Credit Cards"
let s6 = s5.Replace(' ', '~');;

let s7 = s6.Replace("Student","Teacher");;

let s8 = "中国人民银行"
let s9 = "北京市分行"
let ts = s8.PadRight(10), (s9.PadLeft(10,'*'));;

let b1 = (s8 = (fst ts).Trim()) && (s9 = (snd ts).Trim('*'));;

let cs = "中国人民银行".ToCharArray();;

let ss = "Happy Students Have Student Credit Cards".Split(' ');;

let s10 = System.String.Format("{0}级{1}班", 2009, 8);;

let s11 = System.String.Format("{0}时{1}分{2}秒", 11, 59, 59);;