// See https://aka.ms/new-console-template for more information

static double Operacao(double x, double y, string z)
{
    switch (z)
    {
        case "-": return x - y;
        case "+": return x + y;
        case "*": return x * y;
        case "/": return x / y;
        case null: return 0.0;
        default: return 0.0;
    }
}

static void Menu()
{
    Console.WriteLine("Primeiro valor");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    double y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Operacao");
    string? z = Console.ReadLine();

    double resultado = Operacao(x, y, z);
    System.Console.WriteLine(resultado);
}

Menu();

