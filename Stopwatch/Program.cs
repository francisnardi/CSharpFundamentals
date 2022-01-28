static void Menu()
{
    while (true)
    {
        System.Console.Clear();
        System.Console.WriteLine("Quanto tempo deseja contar?");
        System.Console.WriteLine("m -- minutos");
        System.Console.WriteLine("s -- segundos");
        System.Console.WriteLine("0 -- sair");

        var tempo = System.Console.ReadLine();
        Int64 segundos = 0;

        if (tempo != null && tempo[tempo.Length - 1] == 'm')
        {
            segundos = Convert.ToInt64(tempo.Substring(0, tempo.Length - 1)) * 60;
        }
        else if (tempo != null && tempo[tempo.Length - 1] == 's')
        {
            segundos = Convert.ToInt64(tempo.Substring(0, tempo.Length - 1));
        }
        else if (tempo == "0")
        {
            Console.Clear();
            System.Environment.Exit(0);
        }
        for (int i = 1; i <= segundos; i++)
        {
            System.Console.Write("{0} ", i);
            Thread.Sleep(300);
        }
    }
}

Menu();
