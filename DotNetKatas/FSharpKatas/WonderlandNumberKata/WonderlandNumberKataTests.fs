module WonderlandNumberKataTests

open Xunit
open WonderlandNumberKata

let wonderNum = WonderlandNumber

[<Fact>]
let WonderlandNumberHasSixDigits() =
    Assert.Equal(6, wonderNum |> System.Convert.ToString |> String.length)

[<Theory>]
[<InlineData(2)>]
[<InlineData(3)>]
[<InlineData(4)>]
[<InlineData(5)>]
[<InlineData(6)>]
let TestWonderlandNumber factor = 
    Assert.True(HasAllTheSameDigits wonderNum (wonderNum * factor))