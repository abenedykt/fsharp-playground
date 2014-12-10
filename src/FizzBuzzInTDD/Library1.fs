namespace FizzBuzzInTDD

open Xunit
open FluentAssertions

module ``enviroment tests`` =

    [<Fact>]
    let ``first unit test in f#``() =
        Assert.True(true)

    [<Fact>]
    let ``first unit test that uses fluent assertions``() =
        true.Should().BeTrue("should be true")
