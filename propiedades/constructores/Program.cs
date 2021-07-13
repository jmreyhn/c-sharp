using System;

namespace constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Marta";
            b.SegundoNombre = "Diaz";

            Alumno c = new Alumno(3);
            b.PrimerNombre = "Pedro";

            Alumno d = new Alumno("Raul", "Jimenez");

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
        }
    }
}
