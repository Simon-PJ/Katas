module CardGameWarKata

open System

type Suit = Spade | Club | Diamond | Heart
type Rank = Two | Three | Four | Five | Six | Seven 
          | Eight | Nine | Jack | Queen | King | Ace

type Card = Rank * Suit

type Hand = Card list

type GameState = Active | Player1Wins | Player2Wins

type Game = { Player1 : Hand; Player2: Hand; State: GameState }

type Deck = Card list

let Deck = 
    [(Two, Spade); (Three, Spade); (Four, Spade); (Five, Spade); (Six, Spade); (Seven, Spade); (Eight, Spade); (Nine, Spade); (Jack, Spade); (Queen, Spade); (King, Spade); (Ace, Spade);
    (Two, Club); (Three, Club); (Four, Club); (Five, Club); (Six, Club); (Seven, Club); (Eight, Club); (Nine, Club); (Jack, Club); (Queen, Club); (King, Club); (Ace, Club);
    (Two, Diamond); (Three, Diamond); (Four, Diamond); (Five, Diamond); (Six, Diamond); (Seven, Diamond); (Eight, Diamond); (Nine, Diamond); (Jack, Diamond); (Queen, Diamond); (King, Diamond); (Ace, Diamond);
    (Two, Heart); (Three, Heart); (Four, Heart); (Five, Heart); (Six, Heart); (Seven, Heart); (Eight, Heart); (Nine, Heart); (Jack, Heart); (Queen, Heart); (King, Heart); (Ace, Heart);]
    
let SplitList list =
    List.foldBack (fun x (l,r) -> x::r, l) list ([],[])

let Deal() =
    let random = new System.Random()
    let shuffled = Deck |> List.sortBy(fun _ -> random.Next())

    let hands = SplitList shuffled

    hands |> fun (l, r) -> { Player1 = l; Player2 = r; State = Active}

let Turn game = 
    let p1Card, p1Suit = List.head game.Player1
    let p2Card, p2Suit = List.head game.Player2

    if p1Card > p2Card || (p1Card = p2Card && p1Suit > p2Suit)  then
        let newP1Deck = List.head game.Player2:: List.head game.Player1:: List.tail game.Player1 |> List.rev
        let newP2Deck = List.tail game.Player2
        let state = if List.length newP2Deck = 0 then Player1Wins else Active 
        { Player1 = newP1Deck; Player2 = newP2Deck; State = state }
    else
        let newP1Deck = List.tail game.Player2
        let newP2Deck = List.head game.Player1::List.head game.Player2::List.tail game.Player2 |> List.rev
        let state = if List.length newP1Deck = 0 then Player2Wins else Active 
        { Player1 = newP1Deck; Player2 = newP2Deck; State = state }