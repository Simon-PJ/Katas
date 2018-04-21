module CardGameWarKataTests

open Xunit
open CardGameWarKata

[<Fact>]
let ``Cards are equally dealt``() = 
    let dealt = Deal()
    Assert.Equal(List.length dealt.Player1, List.length dealt.Player2)

[<Fact>]
let ``Player one gets cards after winning turn by rank``() =
    let playerOneHand = [(Three, Spade)]
    let playerTwoHand = [(Two, Spade)]
    let game = { Player1 = playerOneHand; Player2 = playerTwoHand; State = Active }

    let afterTurn = Turn(game)

    Assert.Equal(2, afterTurn.Player1.Length)
    Assert.Equal(0, afterTurn.Player2.Length)

[<Fact>]
let ``Player one gets cards after winning turn by Suit``() =
    let playerOneHand = [(Two, Club)]
    let playerTwoHand = [(Two, Spade)]
    let game = { Player1 = playerOneHand; Player2 = playerTwoHand; State = Active }

    let afterTurn = Turn(game)

    Assert.Equal(2, afterTurn.Player1.Length)
    Assert.Equal(0, afterTurn.Player2.Length)

[<Fact>]
let ``Player two gets cards after winning turn by rank``() =
    let playerOneHand = [(Eight, Heart)]
    let playerTwoHand = [(Ace, Heart)]
    let game = { Player1 = playerOneHand; Player2 = playerTwoHand; State = Active }

    let afterTurn = Turn(game)

    Assert.Equal(0, afterTurn.Player1.Length)
    Assert.Equal(2, afterTurn.Player2.Length)

[<Fact>]
let ``Player two gets cards after winning turn by Suit``() =
    let playerOneHand = [(Jack, Diamond)]
    let playerTwoHand = [(Jack, Heart)]
    let game = { Player1 = playerOneHand; Player2 = playerTwoHand; State = Active }

    let afterTurn = Turn(game)

    Assert.Equal(0, afterTurn.Player1.Length)
    Assert.Equal(2, afterTurn.Player2.Length)

[<Fact>]
let ``Player one loses after running out of cards``() =
    let playerOneHand = [(Queen, Diamond)]
    let playerTwoHand = [(Queen, Heart)]
    let game = { Player1 = playerOneHand; Player2 = playerTwoHand; State = Active }

    let afterTurn = Turn(game)

    Assert.Equal(Player2Wins, afterTurn.State)

[<Fact>]
let ``Player Two loses after running out of cards``() =
    let playerOneHand = [(King, Heart)]
    let playerTwoHand = [(King, Diamond)]
    let game = { Player1 = playerOneHand; Player2 = playerTwoHand; State = Active }

    let afterTurn = Turn(game)

    Assert.Equal(Player1Wins, afterTurn.State)