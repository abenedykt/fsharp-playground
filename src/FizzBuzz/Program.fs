// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 

    let fizzBuzz x = 
        match x with
        | x when x % 15 = 0 -> "FizzBuzz"
        | x when x % 5 = 0 -> "Buzz"
        | x when x % 3 = 0 -> "Fizz"
        | _ -> x.ToString()
    
    let numbers = [1..100]
    let result = List.map(fizzBuzz) numbers
    printfn "%A" result


    0 // return an integer exit code
