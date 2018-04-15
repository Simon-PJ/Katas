module CardGameWarKataTests

open Xunit
open CardGameWarKata

[<Fact>]
let ``Cards are equally dealt``() = 
    let dealt = Deal()
    Assert.Equal(List.length dealt.Player1, List.length dealt.Player2)