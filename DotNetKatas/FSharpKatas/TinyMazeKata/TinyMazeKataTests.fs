module TinyMazeKataTests

open Xunit
open TinyMazeKata

[<Fact>]
let ``Can find way to exit with 3x3 maze``() =
    let maze = [[Start; Space; Wall];
                [Wall; Space; Wall];
                [Wall; Space; Finish]]

    let expectedPath = [[Path; Path; Wall;];
                        [Wall; Path; Wall;];
                        [Wall; Path; Path;]]

    Assert.Equal<MazePiece list list>(expectedPath, SolveMaze maze)

[<Fact>]
let ``Can find way to exit with a 4x4 maze``() =
    let maze = [[Start; Space; Space; Wall];
                [Wall; Wall; Space; Space];
                [Wall; Space; Space; Wall];
                [Wall; Wall; Space; Finish]]

    let expectedPath = [[Path; Path; Path; Wall];
                        [Wall; Wall; Path; Space];
                        [Wall; Space; Path; Wall];
                        [Wall; Wall; Path; Path]]

    Assert.Equal<MazePiece list list>(expectedPath, SolveMaze maze)