namespace FizzBuzzInTDD
module FizzBuzz =
    open Xunit
    open Xunit.Extensions
    open FsUnit.Xunit

        let FizzBuzz number =
            match number with
            | number when number % 15 = 0 -> "FizzBuzz"
            | number when number % 3 = 0 -> "Fizz"
            | number when number % 5 = 0 -> "Buzz"
            | _  -> number.ToString()

         [<Theory>]
         [<InlineData(1,"1")>]
         [<InlineData(2,"2")>]
         [<InlineData(3,"Fizz")>]
         [<InlineData(5,"Buzz")>]
         [<InlineData(15,"FizzBuzz")>]
         let `` FizzBuzz should return Fizz on divisible 3, buzz on divisible 5, FizzBuzz on div 15 and the number otherwise`` number expected =
            number
            |> FizzBuzz
            |> should equal expected