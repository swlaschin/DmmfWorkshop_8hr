// =================================
// Exercise: OrderLineQty
//
// Given the definition of OrderLineQty below,
// write functions that increments and decrements it.
// =================================


/// I have defined the "library" code for OrderLineQty here
module ConstrainedTypes =

    /// Must be between >= 1 and <= 100
    type OrderLineQty = private OrderLineQty of int

    module OrderLineQty =

        /// Public function to create a OrderLineQty.
        /// I.e. wrap an int in a OrderLineQty (if possible!).
        /// Used like a "factory method" "constructor" etc
        let create qty =
            // IMPORTANT! In F# if/then/else is an *expression*
            // not a statement, so each branch must return something
            // and all branches must return the same type
            // The nearest equivalent in C-like languages
            // is the ternary "if"
            //    if x ? a : b
            if qty < 1 then
                None
            else if qty > 100 then
                None
            else
                Some (OrderLineQty qty)

        /// define the maximum allowed value
        let maxValue =
            OrderLineQty 100

        /// define the minimum allowed value
        let minValue =
            OrderLineQty 1

        /// Public function to get the data out of a OrderLineQty
        /// An "unwrapper" or "deconstructor" function
        let value olQty =
            match olQty with
            | OrderLineQty qty -> qty

        // short version of the code above
        (*
        let value (OrderLineQty qty) =
            qty
        *)


// ---------------------------------------
// Exercise starts here
// ---------------------------------------

// bring the ConstrainedTypes module into scope
open ConstrainedTypes

// Exercise: Write a function that adds one to an OrderLineQty
// It will have to return an option. Why?
let increment (olq:OrderLineQty) =
    let i1 = OrderLineQty.value olq   // i1 is an int
    let i2 = i1 + 1                   // i2 is an int
    ???                               // return an OrderLineQty here

// Exercise: Write a function that subtracts one from an OrderLineQty
let decrement (olq:OrderLineQty) =
    ???



// ----------------------
// test your code
// ----------------------

// increment the smallest and largest values
increment OrderLineQty.minValue
increment OrderLineQty.maxValue

// decrement the smallest and largest values
decrement OrderLineQty.minValue
decrement OrderLineQty.maxValue

