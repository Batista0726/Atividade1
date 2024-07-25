using System;

class HelloWorld
{
    public static void Escreve()
    {
        Console.WriteLine("\r\n██╗░░██╗███████╗██╗░░░░░██╗░░░░░░█████╗░░░░  ██╗░░░██╗░█████╗░██╗░░░██╗██████╗░\r\n██║░░██║██╔════╝██║░░░░░██║░░░░░██╔══██╗░░░  ╚██╗░██╔╝██╔══██╗██║░░░██║██╔══██╗\r\n███████║█████╗░░██║░░░░░██║░░░░░██║░░██║░░░  ░╚████╔╝░██║░░██║██║░░░██║██████╔╝\r\n██╔══██║██╔══╝░░██║░░░░░██║░░░░░██║░░██║██╗  ░░╚██╔╝░░██║░░██║██║░░░██║██╔══██╗\r\n██║░░██║███████╗███████╗███████╗╚█████╔╝╚█║  ░░░██║░░░╚█████╔╝╚██████╔╝██║░░██║\r\n╚═╝░░╚═╝╚══════╝╚══════╝╚══════╝░╚════╝░░╚╝  ░░░╚═╝░░░░╚════╝░░╚═════╝░╚═╝░░╚═╝\r\n\r\n░█████╗░░█████╗░███╗░░░███╗██████╗░██╗░░░██╗████████╗███████╗██████╗░  ██╗░░██╗░█████╗░░██████╗\r\n██╔══██╗██╔══██╗████╗░████║██╔══██╗██║░░░██║╚══██╔══╝██╔════╝██╔══██╗  ██║░░██║██╔══██╗██╔════╝\r\n██║░░╚═╝██║░░██║██╔████╔██║██████╔╝██║░░░██║░░░██║░░░█████╗░░██████╔╝  ███████║███████║╚█████╗░\r\n██║░░██╗██║░░██║██║╚██╔╝██║██╔═══╝░██║░░░██║░░░██║░░░██╔══╝░░██╔══██╗  ██╔══██║██╔══██║░╚═══██╗\r\n╚█████╔╝╚█████╔╝██║░╚═╝░██║██║░░░░░╚██████╔╝░░░██║░░░███████╗██║░░██║  ██║░░██║██║░░██║██████╔╝\r\n░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚═╝░░░░░░╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝  ╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░\r\n\r\n██╗░░░██╗██╗██████╗░██╗░░░██╗░██████╗\r\n██║░░░██║██║██╔══██╗██║░░░██║██╔════╝\r\n╚██╗░██╔╝██║██████╔╝██║░░░██║╚█████╗░\r\n░╚████╔╝░██║██╔══██╗██║░░░██║░╚═══██╗\r\n░░╚██╔╝░░██║██║░░██║╚██████╔╝██████╔╝\r\n░░░╚═╝░░░╚═╝╚═╝░░╚═╝░╚═════╝░╚═════╝░");
    }
}

class Calculadora
{
    public static void Inicia()
    {
        Console.WriteLine("\nSelecione a Operação:\n" +
            "1: Soma\n" +
            "2: Subtração\n" +
            "3: Multiplicação\n" +
            "4: Divisão");

        Console.Write("> ");
        string op = Console.ReadLine();

        Console.Write("Numero 1: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.Write("Numero 2: ");
        float num2 = float.Parse(Console.ReadLine());

        float? resultado = Calcula(op, num1, num2);

        if (resultado == null)
        {
            Console.WriteLine("\nOperação Inválida");
            return;
        }

        Console.WriteLine($"\nResultado: {resultado}");
    }

    public static float? Calcula(string op, float num1, float num2)
    {
        return op switch
        {
            "1" => num1 + num2,
            "2" => num1 - num2,
            "3" => num1 * num2,
            "4" => num1 / num2,
            _ => null
        };
    }
}

class ParImpar
{
    public static void Inicia()
    {
        Console.Write("\nDigite um Número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("\nPar!");
        }
        else
        {
            Console.WriteLine("\nÍmpar");
        }
    }
}

class Program
{
    public static bool deve_sair = false;

    public static void Main(string[] args)
    {
        while (!deve_sair)
        {
            Console.WriteLine("\nEscolha um Programa:\n" +
                "1: Hello World\n" +
                "2: Calculadora\n" +
                "3: Par ou Ímpar");


            Console.Write("? ");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                HelloWorld.Escreve();
            }
            else if (opcao == "2")
            {
                Calculadora.Inicia();
            }
            else if (opcao == "3")
            {
                ParImpar.Inicia();
            }

        }
    }
}