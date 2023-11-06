using ColConsultas.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Metodos me = new Metodos();
        bool flag = true;
        Console.ForegroundColor = ConsoleColor.Green;
        while (flag)
        {
            switch (me.Menu())
            {
                case 1:
                System.Console.WriteLine("Opcion 1");
                    break;
                case 2:
                System.Console.WriteLine("Saliendo del programa");
                    flag = false;
                    break;
            }

        }
    }
}