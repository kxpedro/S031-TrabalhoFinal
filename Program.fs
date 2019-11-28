    
    
    
    open System

        let Calculadora (a:double)  (b:double)  (op:string) =
            if not (System.String.IsNullOrEmpty(op))
            then
                if op.Equals("+")
                then                      
                    printfn "Resultado: %f" (a + b)
                elif op.Equals("-")
                then          
                    printfn "Resultado: %f" (a - b)
                elif op.Equals("*")
                then          
                    printfn "Resultado: %f" (a * b)
                elif op.Equals("/")          
                then                    
                    printfn "Resultado: %f" (a / b)
                else
                    printfn "Erro ao calcular."
            else
                printfn "Operação Invalida."

        [<EntryPoint>]
            let main argv =
                Calculadora 2.0 2.0 "+"
                Calculadora 2.0 2.0 "-"
                Calculadora 2.0 2.0 "*"
                Calculadora 2.0 2.0 "/"
                System.Console.ReadKey() |> ignore
                0