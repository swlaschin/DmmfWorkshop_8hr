# Workshop: Domain Modeling Made Functional (8 hour version)

Functional programming and domain-driven design might not seem to be a good match,
but in fact functional programming can be an excellent approach to designing decoupled,
reusable systems with a rich domain model. This workshop will show you why.

This will be a hands-on workshop designed for beginners in functional programming.
We'll lots of exercises that cover both low-level implementation and high-level design.


## Who is this for?

This will be especially useful for people learning functional programming -- all concepts used in the workshop will be explained. Previous development experience is recommended.

## What you'll learn

* How to represent the nouns and verbs of a domain using types and functions
* How to decouple the pure domain logic from the outside world
* How to ensure that constraints and business rules are captured in the design
* How to represent state transitions in the domain model
* How to separate I/O from core code

By the end of the workshop you'll know how to build working solutions
with rich domain models, using only functional programming techniques.

## Program

* Overview of DDD principles
  * Domain modelling with AND/OR
* Introduction to functional programming
* Domain Modeling with algebraic types
  * Records, choices, simple types (SCU), and functions
  * Modeling constraints, options
  * Making illegal states unrepresentable
  * Modeling states
* Keeping IO at the edges
  * Validating the input
  * Exercises: IO at the edges

## Prerequisites

We will be using F# as our development language. No experience with F# needed.
Please install the F# compiler and an F#-friendly editor such as Visual Studio Code using the instructions at fsharp.org or http://ionide.io

## Install F#

* [Instructions for Visual Studio and VS Code](https://docs.microsoft.com/en-us/dotnet/fsharp/get-started/install-fsharp).
  If you use VS Code, be sure to install the "Ionide" plugin.
* [Instructions for JetBrains Rider](https://www.jetbrains.com/help/rider/F_Sharp.html)


* Check that F# is working
  * Open `src/00-HelloWorld.fsx` and follow instructions to check that F# is working

## Directory Structure

These folders contain the exercises we will do

* /src/ contains the code

