using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColConsultas.Entities
{
    public class Metodos
    { //public void menu() metodos que no retornan y se pueden llamar si se instancia la clase
    //public static menu () metodos que solo se pueden llamar dentro de la clae
    //public int menu() se puede llamar fuera de la clase y retorna dependiendo del tipo de dato que sea el metodo 
        public  int Menu()
        {
            Console.WriteLine("\n1.Ver Lista de estudiantes" +
           "\n2.Ver lista de materias" +
           "\n3.Ver Materias de cada estudiante" +
           "\n4.Salir del programa");


           Console.Write("Ingrese la opcion que desea realizar :");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}