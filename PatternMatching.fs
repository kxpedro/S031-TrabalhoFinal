// Learn more about F# at http://fsharp.org

open System

let genRate = function
    | "potato" -> 10.00
    | "carrot" -> 20.00    
    | _ -> nan (* nan is a special value meaning "not a number" *)    

let function1 x =
    match x with
    | (var1, var2) when var1 > var2 -> printfn "%d is greater than %d" var1 var2
    | (var1, var2) when var1 < var2 -> printfn "%d is less than %d" var1 var2
    | (var1, var2) -> printfn "%d equals %d" var1 var2

[<EntryPoint>]
let main argv =
    function1 (1, 2)
    function1 (2, 1)
    function1 (3, 3)    
    System.Console.ReadKey() |> ignore
    //
    printfn "\n"
    //
    printfn "%g" (genRate "potato")
    printfn "%g" (genRate "carrot")
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
