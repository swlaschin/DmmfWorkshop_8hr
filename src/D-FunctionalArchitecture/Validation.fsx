namespace global  // note use of GLOBAL namespace

open System


//==============================================
// The `Validation` type is the same as the `Result` type but with a *list* for failures
// rather than a single value. This allows `Validation` types to be combined
// by combining their errors ("applicative-style")
//==============================================

type Validation<'TSuccess,'TError> =
    Result<'TSuccess,'TError list>

/// Functions for the `Validation` type (mostly applicative)
[<RequireQualifiedAccess>]  // RequireQualifiedAccess forces the `Validation.xxx` prefix to be used
module Validation =

    let map f (x1OrError:Validation<_,_>) :Validation<_,_> =
        match x1OrError with
        | Ok x -> Ok (f x)
        | Error e -> Error e

    /// Lift a two parameter function to use Validation parameters
    let map2 f (x1OrError:Validation<_,_>) (x2orError:Validation<_,_>) :Validation<_,_> =
        match x1OrError,x2orError with
        | Ok x1, Ok x2 -> Ok (f x1 x2)
        | Error e1, Ok _ -> Error e1
        | Ok _, Error e2 -> Error e2
        | Error e1, Error e2 -> Error (List.concat [e1;e2] )

    /// Lift a three parameter function to use Validation parameters
    let map3 f (x1OrError:Validation<_,_>) (x2orError:Validation<_,_>) (x3orError:Validation<_,_>) :Validation<_,_> =
        match x1OrError,x2orError,x3orError with
        | Ok x1, Ok x2, Ok x3 -> Ok (f x1 x2 x3)
        | Error e1, Ok _, Ok _ -> Error e1
        | Ok _, Error e2, Ok _ -> Error e2
        | Ok _, Ok _, Error e3 -> Error e3
        | Error e1, Error e2, Ok _ -> Error (List.concat [e1; e2])
        | Ok _, Error e2, Error e3  -> Error (List.concat [e2; e3])
        | Error e1, Ok _, Error e3 -> Error (List.concat [e1; e3])
        | Error e1, Error e2, Error e3 -> Error (List.concat [e1; e2; e3])
