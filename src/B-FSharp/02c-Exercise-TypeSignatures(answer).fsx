// =============================================
// Exercise Part 1:
//
// For each of the following definitions,
// say whether it is a simple value or a function,
// and if a function, what is the function signature?
//
// If in doubt, run them to find out!
// =============================================

let testA = 2
// simple value
// val testA : int = 2

let testB x = 2 + x
// function
// val testB : x:int -> int

let testC x = 2.0 + x
// function
// val testC : x:float -> float

let testD = "hello"
// simple value
// val testD : string = "hello"

let testE = printfn "hello"
// simple value (with no useful value)
// val testE : unit = ()

let testF() = 42
// function (with no useful input)
// val testF : unit -> int

let testG() = printfn "hello"
// function (with no useful input or output)
// val testG : unit -> unit

let testH x = String.length x
// function
// val testH : x:string -> int

let testI x = sprintf "%i" x
// function
// val testI : x:int -> string

let testJ x = printfn "%i" x
// function (with no useful output)
// val testJ : x:int -> unit

let testK x =
    printfn "x is %f" x
    x  // return x
// function
// val testK : x:float -> float

let testL (f:int -> string) x =
    f x
// val testL : f:(int -> string) -> x:int -> string


// =============================================
// Exercise Part 2:
//
// For each of the following signatures, create a function
// that will be *inferred* to have that signature.
//
// Avoid using explicit type annotations!
// =============================================

// val sigA = int -> int
let sigA x = x + 1

// val sigB = int -> unit
let sigB x = printfn "%i" x

// val sigC = int -> string
let sigC x = sprintf "%i" x

// val sigD = unit -> string
let sigD() = "hello"

// val sigE = string -> string
let sigE x = sprintf "%s" x
// NOTE
//  let sigE x = x
// does NOT work because the input can be ANY type (as shown by the generic type 'a)

// val sigF = int -> bool -> float -> string
let sigF anInt aBool aFloat = sprintf "%i %b %f" anInt aBool aFloat


// =============================================
// Exercise Part 3:
//
// Make the following functions compile by adding
// type annotations. Try to use the minimum annotations possible!
//
// Here's how to do type annotations
// let aFunction (param1:string) (param2:bool) :string =
//                ^1st param      ^2nd param    ^return type
//
// =============================================

// Remove spaces from front and back of a string
// The "s" parameter is a string and it returns a string
let trim (s:string) = s.Trim()

// Return the length of string
// The "s" parameter is a string and it returns an int
let len (s:string) = s.Length


// =============================================
// Exercise Part 4 (HARD):
// Below are four generic signatures.
// Try to create four functions that are inferred to have these signatures.
//
// Avoid using explicit type annotations!
// =============================================

// val sigW = 'a -> int
let sigW x = 1

// val sigX = int -> 'a
// not possible to implement without cheating!
// but if you use exceptions, you can write
let sigX x =
    printfn "%i" x
    failwith "error"   // raise exception!

// val sigY = 'a -> 'a
let sigY x = x

// val sigZ = 'a -> 'b
// not possible to implement without cheating!
// but if you use exceptions, you can write
let sigZ x =
    failwith "error"   // raise exception!
