module TinyMazeKata

type MazePiece = Start | Finish | Wall | Space | Path

let SolveMaze maze =
    [[Start];[Wall]]