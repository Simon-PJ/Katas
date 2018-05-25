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

let rec CalcWonderlandNumber numUnderTest =
    if IsWonderlandNumber numUnderTest then
        numUnderTest
    else
        CalcWonderlandNumber (numUnderTest-1)

let WonderlandNumber = 
    CalcWonderlandNumber 999999