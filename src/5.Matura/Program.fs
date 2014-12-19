// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System

[<EntryPoint>]
let main argv =

    let numbers = [1..40000]

    let lastDigit n =
        let square = (n * n).ToString()
        square.Chars(square.Length - 1)

    numbers
    |> List.map lastDigit
    |> Seq.distinct 
    |> Seq.iter (printf " %c")

    printfn ""
    0 // return an integer exit code
