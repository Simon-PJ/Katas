module CardGameWarKata

open System

type Suit = Spade | Club | Diamond | Heart
type Rank = Two | Three | Four | Five | Six | Seven 
          | Eight | Nine | Jack | Queen | King | Ace

type Card = Rank * Suit

type Hand = Card list

type Game = { Player1 : Hand; Player2: Hand }

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
    let shuffled = Deck |> List.sortBy(fun card -> random.Next())

    let hands = SplitList shuffled

    hands |> fun (l, r) -> { Player1 = l; Player2 = r}