# Tiny Maze Kata #

[Link](https://github.com/gigasquid/wonderland-clojure-katas/tree/master/tiny-maze)

Alice found herself very tiny and wandering around Wonderland. Even the grass around her seemed like a maze.

This is a tiny maze solver.

A maze is represented by a matrix

    [[:S 0 1]
     [1  0 1]
     [1  0 :E]]

- S: start of the maze
- E: end of the maze
- 1: this is a wall that you cannot pass through
- 0: a free space that you can move through

The goal is to get to the end of the maze. A solved maze will have a :x in the start, and at the end of the maze, like this:

    [[:x :x 1]
     [1  :x 1]
     [1  :x :x]]