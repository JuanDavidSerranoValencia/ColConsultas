using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColConsultas.Entities
{
    public class EstudianteMateria
    {
        public int IdEstudianteFk { get; set; }
        public Estudiante Estudiante { get; set; }

        public int IdMateriaFk { get; set; }
        public Materia Materia { get; set; }

    }
}