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

       
    }
}