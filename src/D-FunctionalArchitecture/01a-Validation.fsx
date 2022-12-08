// ================================================
// Example: Combine errors when doing validation
// ================================================

// Load a file with library functions for Validation
#load "Validation.fsx"

// =============================================
// The domain
// =============================================

/// Define types for this domain
module MyDomain =

    // String10 must be not empty AND len < 10
    type String10 =  private String10 of string

    type PersonalName = {
        First: String10
        Last: String10
        }

    module String10 =
        // pass in a field name so that we know which field had the error
        let create fieldName s =
            if System.String.IsNullOrEmpty(s) then
                let errMsg = sprintf "%s is null or empty" fieldName
                Error [errMsg]
            else if (s.Length > 10) then
                let errMsg = sprintf "%s is too long" fieldName
                Error [errMsg]
            else
                Ok (String10 s)

        let value (String10 s) = s



// -------------------------------
// test that the validation works for PersonalName
// -------------------------------

open MyDomain

/// Create a constructor for PersonalName
let createName (first:String10) (last:String10) :PersonalName =
    {First=first; Last=last}

// --------------------------------------------
// example 1 - good data
// (run this whole chunk)
// --------------------------------------------

let goodName =
    // input from user
    let strFirst = "Albert" // less than 10 -- good!
    let strLast = "Smith"   // less than 10 -- good!

    let firstOrError =
        strFirst
        |> String10.create "FirstName"

    let lastOrError =
        strLast
        |> String10.create "LastName"

    let personOrError =
        (Validation.map2 createName) firstOrError lastOrError
//       ^this converts a normal function
//       to a function that accumulates errors

    personOrError // return

// --------------------------------------------
// example 2 - bad data
// (run this whole chunk)
// --------------------------------------------

let badName =
    // input from user
    let strFirst = "Jean-Claude"   // more than 10 -- bad!
    let strLast = ""               // empty -- bad!

    let firstOrError =
        strFirst
        |> String10.create "FirstName"

    let lastOrError =
        strLast
        |> String10.create "LastName"

    let personOrError =
        (Validation.map2 createName) firstOrError lastOrError

    personOrError // return

