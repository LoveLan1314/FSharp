module Knapsack

let rec ks c w (v: int list) =
    if c <= 0 then 0
    elif List.length w = 1 then
        if w.Head > c then 0
        else v.Head
    else 
        let w' = w.Tail
        let v' = v.Tail
        if w.Head > c then ks c w' v'
        else max (ks c w' v') ((ks (c-w.Head) w' v') + v.Head)

let ks90 = ks 90
let x1 = ks90 [20; 30; 40; 50] [4; 5; 4; 9];;

let x2 = ks90 [15; 18; 21; 24; 30; 33] [5; 7; 8; 11; 15; 15];;