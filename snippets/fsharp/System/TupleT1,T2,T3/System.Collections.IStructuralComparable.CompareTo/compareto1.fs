﻿module compareto1

// <Snippet1>
open System

let scores = 
    [| Tuple.Create("Jack", 78.8, 8)
       Tuple.Create("Abbey", 92.1, 9)
       Tuple.Create("Dave", 88.3, 9)
       Tuple.Create("Sam", 91.7, 8)
       Tuple.Create("Ed", 71.2, 5)
       Tuple.Create("Penelope", 82.9, 8)
       Tuple.Create("Linda", 99.0, 9)
       Tuple.Create("Judith", 84.3, 9) |]
 
printfn "The values in unsorted order:"
for score in scores do
    printfn $"{score}"

printfn ""

Array.Sort scores

printfn "The values in sorted order"
for score in scores do
    printfn $"{score}"
// The example displays the following output
//    The values in unsorted order:
//    (Jack, 78.8, 8)
//    (Abbey, 92.1, 9)
//    (Dave, 88.3, 9)
//    (Sam, 91.7, 8)
//    (Ed, 71.2, 5)
//    (Penelope, 82.9, 8)
//    (Linda, 99, 9)
//    (Judith, 84.3, 9)
//    
//    The values in sorted order:
//    (Abbey, 92.1, 9)
//    (Dave, 88.3, 9)
//    (Ed, 71.2, 5)
//    (Jack, 78.8, 8)
//    (Judith, 84.3, 9)
//    (Linda, 99, 9)
//    (Penelope, 82.9, 8)
//    (Sam, 91.7, 8)
// </Snippet1>