# Toy Robot Simulator

## Description
This application simulates a toy robot moving on a 5x5 grid tabletop. The robot follows specific commands to move, rotate, and report its position.

## Features
- The robot can be placed on the grid using the `PLACE X,Y,F` command.
- The robot can move forward using the `MOVE` command.
- The robot can rotate left or right using `LEFT` and `RIGHT` commands.
- The `REPORT` command outputs the current position and direction of the robot.
- The robot will not move off the table.

## Installation
Clone this repository:
- git clone https://github.com/sangspd20/RobotSimulator

## Usage
Commands should be written in `commands.txt`, for example:
```
PLACE 0,0,NORTH
MOVE
RIGHT
MOVE
REPORT
```
Output:
```
1,1,EAST
```

## Commands
- `PLACE X,Y,F` - Places the robot at (X, Y) facing F (NORTH, SOUTH, EAST, or WEST).
- `MOVE` - Moves the robot one unit forward in the direction it is facing.
- `LEFT` - Rotates the robot 90 degrees left.
- `RIGHT` - Rotates the robot 90 degrees right.
- `REPORT` - Outputs the current position and direction.

## Testing
To test the program, modify `commands.txt` with different command sequences and run the script again.


