using LFA_HT2;
Main();
static void Main()
{
    ht2 HT2 = new ht2();
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Hoja de Trabajo #2");
    Console.ResetColor();

    Console.WriteLine("\nUsar Arriba y Abajo para navegar, y usar Enter para seleccionar:");
    (int left, int top) = Console.GetCursorPosition();
    var option = 1;
    var decorator = "-> \u001b[32m";
    ConsoleKeyInfo key;
    bool isSelected = false;

    while (!isSelected)
    {
        Console.SetCursorPosition(left, top);

        Console.WriteLine($"{(option == 1 ? decorator : "   ")}Problema 1\u001b[0m");
        Console.WriteLine($"{(option == 2 ? decorator : "   ")}Problema 2\u001b[0m");
        Console.WriteLine($"{(option == 3 ? decorator : "   ")}Problema 3\u001b[0m");

        key = Console.ReadKey(false);

        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                option = option == 1 ? 3 : option - 1;
                break;

            case ConsoleKey.DownArrow:
                option = option == 3 ? 1 : option + 1;
                break;

            case ConsoleKey.Enter:
                isSelected = true;
                break;
        }
    }

    Console.Clear();

    switch (option)
    {
        case 1:
            HT2.ReconocimientoDePlacas();
            Main(); break;
        case 2:
            HT2.ReconocimientoDeFechas();
            Main(); break;
        case 3:
            HT2.ReconocimientoDeSets();
            Main(); break;
    }

}
