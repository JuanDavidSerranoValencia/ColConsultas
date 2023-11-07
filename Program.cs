using ColConsultas.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Metodos me = new Metodos();
        bool flag = true;
        while (flag)
        {
            switch (me.Menu())
            {
                case 1:
                    me.ObtenerEstudiantes();
                    break;
                case 2:
                    me.ObtenerMaterias();
                    break;
                case 3:
                    me.MateriasEstudiantes();
                    break;
                case 4:
                    System.Console.WriteLine("Saliendo del programa");
                    flag = false;
                    break;
                default:
                    System.Console.WriteLine("Ingrese una opcion valida");
                    break;
            }

        }
    }
}