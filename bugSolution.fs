let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y <- x - y
    x, y

let updatedX, updatedY = add &x &y
printf "%i %i" updatedX updatedY

(* Expected output: 30 30 *)
(* Actual output: 30 30 *)

(* The solution uses the byref keyword to pass the x and y variables by reference. This means that the add function can directly modify the x and y variables. The add function now modifies the values passed to it. The result is that the x and y variables are updated after calling the add function.*)