using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColConsultas.Entities
{
    public class Materia:BaseEntity
    {
        public string NombreMateria { get; set; }
        public int Creditos { get; set; }

        List<Materia> Materias = new List<Materia>(){
            new Materia(){
                Id =1,
                NombreMateria = "Matematicas",
                Creditos=4
            },
               new Materia(){
                Id =2,
                NombreMateria = "Filosofia",
                Creditos=2
            }

        };
    }
}