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

let DecodeChar (inputChar: char) (keywordChar: char) =
    let sum = (int inputChar) - 97
    let inputCharInt = sum - (int keywordChar) + 194

    if inputCharInt < 97 then
        let adjusted = inputCharInt + 26
        (char adjusted)
    else 
        (char inputCharInt)

let DecipherChar (inputChar: char) (outputChar: char) =
    let sum = (int outputChar) - 97
    let keywordCharInt = sum - (int inputChar) + 194

    if keywordCharInt < 97 then
        let adjusted = keywordCharInt + 26
        (char adjusted)
    else 
        (char keywordCharInt)
     
let RepeatKeyword (input: string) (keyword: string) = 
    let multiplier = (String.length input / String.length keyword) + 1
    let repeated = String.replicate multiplier keyword
    repeated.[0..String.length input - 1]

let Encode input keyword = 
    RepeatKeyword input keyword 
    |> Seq.zip input
    |> Seq.map (fun (x, y) -> GetIntersect x y) 
    |> System.String.Concat

let Decode input keyword = 
    RepeatKeyword input keyword
    |> Seq.zip input
    |> Seq.map (fun (x, y) -> DecodeChar x y)
    |> System.String.Concat

let rec FindMinKeyword (keyword:string) input output n =
    let substring = keyword.[0..n]

    if Encode input substring = output then
        substring
    else
        FindMinKeyword keyword input output (n+1)

let Decipher input output = 
    let longKeyword = 
        input
        |> Seq.zip output
        |> Seq.map (fun (x, y) -> DecipherChar y x)
        |> System.String.Concat

    FindMinKeyword longKeyword input output 0