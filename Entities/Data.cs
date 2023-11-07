using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColConsultas.Entities
{
    public class Data
    {
        public List<Estudiante> LsEstudiantes = new List<Estudiante>(){

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



        public List<EstudianteMateria> LsEstudianteMaterias = new List<EstudianteMateria>(){
            new EstudianteMateria(){
                IdEstudianteFk=1,
                IdMateriaFk=1
            },
             new EstudianteMateria(){
                IdEstudianteFk=1,
                IdMateriaFk=2
            },
             new EstudianteMateria(){
                IdEstudianteFk=2,
                IdMateriaFk=1
            }

        };


         public List<Materia> Materias = new List<Materia>(){
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