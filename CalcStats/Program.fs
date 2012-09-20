// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let arr = [|
                6
                9
                15
                -2
                92
                11
            |]

let calcstat (arr : int[]) =
    printf "minimum value = %d\n" (Array.min arr)
    printf "maximum value = %d\n" (Array.max arr)
    printf "num of element = %d\n" (Array.length arr)
    printf "avarage = %f\n" (Array.averageBy (fun elem -> float elem) arr)

[<EntryPoint>]
let main argv = 
    calcstat arr
    0 // return an integer exit code
