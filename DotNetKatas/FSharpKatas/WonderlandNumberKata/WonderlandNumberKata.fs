module WonderlandNumberKata

open System

let HasAllTheSameDigits (n1: int) (n2: int) = 
    let sortDigits (n: int) =
        n 
        |> System.Convert.ToString 
        |> Seq.sort 
        |> String.Concat

    sortDigits n1 = sortDigits n2

let IsWonderlandNumber num =
    [2..6] |> List.forall (fun x -> HasAllTheSameDigits num (num*x))

let WonderlandNumber = 
    [111111..999999] 
    |> List.filter (fun x -> IsWonderlandNumber x)
    |> List.head