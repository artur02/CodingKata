// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let mod3 num = num%3=0
let mod5 num = num%5=0

let (|DivThreeFive|DivThree|DivFive|General|)  (number : int) = 
    if mod3 number && mod5 number then DivThreeFive
    elif mod3 number then DivThree 
    elif mod5 number then DivFive
    else General                                

let fizzbuzz =
    for i=1 to 100 do
        match i with
        | DivThree -> printf "Fizz"
        | DivFive -> printf "Buzz"
        | DivThreeFive -> printf "FizzBuzz"
        | General -> printf "%d" i
        printf "\n"

[<EntryPoint>]
let main argv = 
    fizzbuzz
    0 // return an integer exit code