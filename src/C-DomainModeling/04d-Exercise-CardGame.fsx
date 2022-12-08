// ================================================
// Exercise: Model a card game
//
// ================================================

(*
The domain model is:

* A card is
  * a combination of a Suit (Heart, Spade) and a Rank (Two, Three, ... King, Ace)
  * OR a Joker
* A hand is a list of cards
* A deck is a list of cards
* A shuffled deck is also a list of cards, but different from a normal deck
* A player has a name and a hand
* A game consists of a deck and list of players

Actions:
* To deal, remove a card from a shuffled deck and put it on the table
* To pick up a card, add a card to a hand
* To shuffle, start with a normal deck and create a shuffled deck from it

Exercise:
* Define types to represent the domain
* Implement any functions that you can (look at the answer file if you get stuck)
*)

module CardGame =

    type Suit = ??
    type Rank = ??
    type Card = ??

    type Hand = ??
    type Deck = ??
    type ShuffledDeck = ??

    type Player = ??
    type Game = ??

    // what if the deck is empty?
    type Deal = ??
    type PickUp = ??
    type Shuffle = ??

(*
// Question: 
//    How do you document the rules of the game using types?
// Answer: 
//    You can't -- you can only document the key concepts.
//    For example, the algorithm used to shuffle cards or to score hands.
//    Just add a comment such as "See algorithm.doc for details"
*)


(*
// Question: 
//    How do you model extra behavior,
//    such as calculating the scoring of a Hand?
//           
// Answer: 
//    In OO you would add methods to the Card and Hand
//    In FP we would have a function to transform a Hand 
//    to a new kind of thing, such as a "Score" type.
//    See below.
*)

    /// Aces High rule is used in Poker,
    /// or must be agreed at the beginning
    type AreAcesHigh = bool

    // You might want to score cards and hands.
    // For example Ace=13 Two=2
    type Score = int // no constraint -- can be large when adding up a hand

    // calculate a score for one single card
    type ScoreCard = Card * AreAcesHigh -> Score
    // calculate a score for a complete hand
    type ScoreHand = ??

// =====================================
// See answer file for a Card Game implementation
// =====================================
