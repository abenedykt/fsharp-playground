open System
open System.Numerics

[<EntryPoint>]
let main argv =

    let endVal:BigInteger = 400000000000I

    let numbers:bigint seq =
        let rec loop n = seq { yield n; yield! loop (n+1I) }
        loop 0I

    let lastDigit (n:BigInteger) =
        let square = (n * n).ToString()
        square.Chars(square.Length - 1)

    let trace (x:BigInteger) =
        if x % 100000000I = 0I then Console.WriteLine("f# " + x.ToString())
        x

    numbers
    |> Seq.map trace
    |> Seq.map lastDigit
    |> Seq.distinct
    |> Seq.iter (printf " %c")

    printfn "end"
    let k = System.Console.ReadLine()
    0 // return an integer exit code