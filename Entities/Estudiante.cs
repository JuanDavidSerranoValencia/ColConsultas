using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColConsultas.Entities
{
    public class Estudiante:BaseEntity
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Identificacion { get; set; }

        List<Estudiante> Estudiantes = new List<Estudiante>(){
            
            new Estudiante(){
                Id =1,
                Nombre = "Carlos Moreno",
                Edad = 22,
                Identificacion = 123
            },

               new Estudiante(){
                Id =2,
                Nombre = "Juan David",
                Edad = 19,
                Identificacion = 321
            }

        };
    }
}