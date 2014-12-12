namespace Slownie

module Slownie =

    open FsUnit.Xunit
    open Xunit

    let Slownie x = "jeden"

    [<Fact>]
    let ``Zamiana 1 na słownie zwraca 'jeden'``() =
        1
        |> Slownie
        |> should equal "jeden"