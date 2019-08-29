using System;
using System.Collections.Generic;
using System.Text;

namespace Nulos
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public List<string> Materias { get; set; }

        public Alumno()
        {
            Materias = new List<string>();
        }
    }
}
