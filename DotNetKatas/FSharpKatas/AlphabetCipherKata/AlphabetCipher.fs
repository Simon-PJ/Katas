module AlphabetCipher

let GetIntersect (inputChar: char) (keywordChar: char) =
    let inputCharInt = (int inputChar) - 97
    let keywordCharInt = (int keywordChar) - 97

    let sum = inputCharInt + keywordCharInt

    if sum >= 26 then
        let adjustedSum = sum - 26 + 97
        (char adjustedSum)
    else
        let adjustedSum = sum + 97
        (char adjustedSum)
        
let RepeatKeyword (input: string) (keyword: string) = 
    let multiplier = (String.length input / String.length keyword) + 1
    let repeated = String.replicate multiplier keyword
    repeated.[0..String.length input - 1]

let Encode input keyword = 
    RepeatKeyword input keyword 
    |> Seq.zip input
    |> Seq.map (fun (x, y) -> GetIntersect x y) 
    |> System.String.Concat