// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
module Main

[<EntryPoint>]
let main argv = 

    printfn "%s" File1.hello1
    printfn "%s" File2.hello2
    printfn "%s" File2.hello22
    printfn "hello main"
    0 // return an integer exit code
