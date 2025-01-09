let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let updatedX = add x y
printf "%i" updatedX

let updatedY = add x y
printf "%i" updatedY

(* Expected output: 30 30 *)
(* Actual output: 30 30 *)

(* The bug is that the updatedX and updatedY variables are not updated after calling the add function. This is because the add function is not modifying the x and y variables passed to it. Instead, it's just returning the sum of the x and y variables.*)