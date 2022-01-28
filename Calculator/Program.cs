static double Operacao(double x, double y, string z)
{
    switch (z)
    {
        case "-": return (x - y);
        case "+": return (x + y);
        case "*": return (x * y);
        case "/": return (x / y);
        default: return (x + y);
    }
}

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    double y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Operacao");
    var temp = Console.ReadLine();
    string z = temp is not null ? temp : "+";

    if (temp == "")
        System.Environment.Exit(0);

    double resultado = Operacao(x, y, z);
    System.Console.WriteLine(resultado);
}

Menu();
