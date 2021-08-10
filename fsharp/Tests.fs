module Tests

open System
open Xunit
open Player

[<Fact>]
let ``Player is Player One`` () =
    let player: Player = PlayerOne
    Assert.Equal(Player.PlayerOne, player);

[<Fact>]
let ``Player is Player Two`` () =
    let player: Player = PlayerTwo
    Assert.Equal(Player.PlayerTwo, player);
