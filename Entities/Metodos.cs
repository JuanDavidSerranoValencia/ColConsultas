using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ColConsultas.Entities
{
    public class Metodos
    { //public void menu() metodos que no retornan y se pueden llamar si se instancia la clase
      //public static menu () metodos que solo se pueden llamar dentro de la clae
      //public int menu() se puede llamar fuera de la clase y retorna dependiendo del tipo de dato que sea el metodo 

        //Estudiante est = new Estudiante();

        Data datos = new Data();
        public int Menu()
        {
            Console.WriteLine("\n1.Ver Lista de estudiantes" +
           "\n2.Ver lista de materias" +
           "\n3.Ver Materias de cada estudiante" +
           "\n4.Salir del programa");


            Console.Write("Ingrese la opcion que desea realizar :");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }

        public void ObtenerEstudiantes()
        {
            Console.Clear();
            //Estudiante est = new Estudiante();
            var lista = (from p in datos.LsEstudiantes select p).ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lista De Estudiantes\n");
            foreach (var item in lista)
            {
                System.Console.WriteLine($"{item.Id}---{item.Nombre}---{item.Identificacion}");
            }
            /// estudiantes.ForEach(est=> System.Console.WriteLine($"{est.Id}---{est.Nombre}---{est.Identificacion}"));
        }
        public void ObtenerMaterias()
        {
            Console.Clear();
            var materias = (from m in datos.Materias select m).ToList();
            System.Console.WriteLine("Lista De Materias\n");
            materias.ForEach(ma => System.Console.WriteLine($"{ma.Id}---{ma.NombreMateria}---{ma.Creditos}"));

        }

        public void MateriasEstudiantes()
        {

            Console.Clear();
            var MatEstu = (from  esma in datos.LsEstudianteMaterias 
            join mat in datos.Materias on esma.IdMateriaFk equals mat.Id
            join est in datos.LsEstudiantes on esma.IdEstudianteFk equals est.Id
            select new {
                Cedula = est.Identificacion,
                NombreEstudiante = est.Nombre,
                Asignatura = mat.NombreMateria,
                Peso = mat.Creditos

            }).ToList();
            

            System.Console.WriteLine("Materias de Estudiante\n");
            MatEstu.ForEach(x => System.Console.WriteLine($"{x.Cedula}--{x.NombreEstudiante}--{x.Asignatura}--{x.Peso}"));

        }
    }
}