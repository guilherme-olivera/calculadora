using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Olá, O que Deseja Fazer? ");
            Console.WriteLine("===================");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("===================");
            Console.WriteLine(" Selecione uma Opção: ");
            short res = short.Parse(Console.ReadLine());

            switch(res){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0);break;
                default: Menu(); break;
            }
        }
        

        static void Soma()
        {
            Console.Clear();
            //input do primeiro numero
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            //input do segundo numero 
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            // formas diferentes de apresentar o resultado
            float resultado = v1+v2;
            // Console.WriteLine("O Resultado da Soma é: " + resultado);            
            Console.WriteLine($"O Resultado da Soma é: {resultado}");// interpolação
            // Console.WriteLine($"O Resultado da Soma é: {v1+v2}");
            // Console.WriteLine($"O Resultado da Soma é: " + (v1 + v2));
            Console.ReadKey();
            Menu();
        }
    
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1-v2;
            Console.WriteLine($"O Resultado da Subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1/v2;
            Console.WriteLine($"O Resultado da Divisão é {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1*v2;
            Console.WriteLine($"O Resultado da Multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
            
        }
    }
    
}