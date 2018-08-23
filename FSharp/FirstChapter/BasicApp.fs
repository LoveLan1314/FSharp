module BasicApp

let fangle a b c = 
    let l = (a+b+c)/2.0
    let s = sqrt (l*(l-a)*(l-b)*(l-c))
    asin (2.0*s/b/c), asin (2.0*s/a/c), asin (2.0*s/a/b)

let fangle1 a b c = 
    let l = (a+b+c)/2.0
    let s = sqrt (l*(l-a)*(l-b)*(l-c))
    asin (2.0*s/b/c) /Complex.pi.r*180.0, asin (2.0*s/a/c) /Complex.pi.r*180.0, 
    asin (2.0*s/a/b) /Complex.pi.r*180.0

let q1 = fangle 3.0 4.0 5.0;;

let q2 = fangle 1.5 1.0 1.5;;

let q3 = fangle1 3.0 4.0 5.0;;

let q4 = fangle1 1.5 1.0 1.5;;