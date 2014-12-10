namespace FizzBuzzInTDD

open Xunit
open FluentAssertions

module EnvironmentTests =

    [<Fact>]
    let First_unit_test_in_fsharp() =
        Assert.True(true)

    [<Fact>]
    let Unit_test_with_fluent_assertions() =
        true.Should().BeTrue("should be true")
