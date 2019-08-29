using System;

namespace Nulos
{
    class Program
    {
        static Alumno alumno;
        static void Main(string[] args)
        {
            alumno = new Alumno();
            alumno.Materias.Add("Matematicas");
            imprimirAlumno();

            Console.Read();
        }

       static void imprimirAlumno()
        {
            try
            {
                alumno.Nombre = "José";
                Console.WriteLine("Nombre: " + alumno.Nombre);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
          
        }

    }
}
