# F# Mutable Variable Update Issue

This repository demonstrates a common issue in F# involving mutable variables and function calls.  The provided code intends to update mutable variables `x` and `y` using a function `add`, but the updates do not persist.  This is due to the nature of value-based parameters in F#. The solution showcases how to correctly achieve the intended variable updates.

## Bug
The initial `bug.fs` file contains code where mutable variables `x` and `y` are not updated as expected after calling the `add` function.  The `add` function calculates the sum, but this value isn't assigned back to the original variables.

## Solution
The `bugSolution.fs` file presents the corrected code.  It addresses the issue by either passing the variables by reference using `byref`, or by returning the updated values from the function and reassigning them to the original variables.

## How to Run
1. Clone this repository.
2. Open the `bug.fs` and `bugSolution.fs` files in an F# editor or IDE.
3. Execute the code to observe the different behaviors.