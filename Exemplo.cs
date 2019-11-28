using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculadora(2, 2, "+"));            
            Console.WriteLine(Calculadora(2, 2, "-"));
            Console.WriteLine(Calculadora(2, 2, "/"));
            Console.WriteLine(Calculadora(2, 2, "*"));
            Console.ReadLine();
        }

        private static string Calculadora(double value1, double value2, string op)
        {
            if (!string.IsNullOrEmpty(op))
            {
                if (op.Equals("+"))
                    return "Resultado: " + (value1 + value2).ToString();
                    //Resultado: 4
                else if (op.Equals("-"))
                    return "Resultado: " + (value1 - value2).ToString();
                    //Resultado: 0
                else if (op.Equals("/"))
                    return "Resultado: " + (value1 / value2).ToString();
                    //Resultado: 1
                else if (op.Equals("*"))
                    return "Resultado: " + (value1 * value2).ToString();
                    //Resultado: 4
                else
                    return "Erro ao calcular.";
            }
            else
                return "Operação invalida.";
        }
    }
}
