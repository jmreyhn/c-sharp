using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            aves a1 = new aves();
            a1.Nombre = "Aguila";
            a1.Metodos = "Volar alto";
            a1.Propiedades= "Pico grande";

            aves a2 = new aves();
            a2.Nombre = "Loro";
            a2.Metodos = "Hablar";
            a2.Propiedades= "Plumaje de colores";

            aves a3 = new aves();
            a3.Nombre = "Búho";
            a3.Metodos = "Visión binocular";
            a3.Propiedades= "Nocturnos";

            mamiferos m1 = new mamiferos();
            m1.Nombre = "Perro";
            m1.Metodos = "Ladrar";
            m1.Propiedades= "Veloz y resistente";

            mamiferos m2 = new mamiferos();
            m2.Nombre = "Gato";
            m2.Metodos = "Maullar";
            m2.Propiedades= "Juguetón";

            mamiferos m3 = new mamiferos();
            m3.Nombre = "Mono";
            m3.Metodos = "Maullar";
            m3.Propiedades= "Inteligente y hábil";

            peces p1 = new peces();
            p1.Nombre = "Pez Globo";
            p1.Metodos = "Inflarse";
            p1.Propiedades= "Venenoso";

            peces p2 = new peces();
            p2.Nombre = "Sardina";
            p2.Metodos = "Pescado azul";
            p2.Propiedades= "Cuerpo alargado";

            peces p3 = new peces();
            p3.Nombre = "Trucha";
            p3.Metodos = "Pez de agua dulce";
            p3.Propiedades= "Las aletas carecen de espinas";

            Console.WriteLine("Nombre: " + a1.Nombre);
            Console.WriteLine("Metodo: " + a1.Metodos);
            Console.WriteLine("Propiedades: " + a1.Propiedades);
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + a2.Nombre);
            Console.WriteLine("Metodo: " + a2.Metodos);
            Console.WriteLine("Propiedades: " + a2.Propiedades);
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + a3.Nombre);
            Console.WriteLine("Metodo: " + a3.Metodos);
            Console.WriteLine("Propiedades: " + a3.Propiedades);
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + m1.Nombre);
            Console.WriteLine("Metodo: " + m1.Metodos);
            Console.WriteLine("Propiedades: " + m1.Propiedades);
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + m2.Nombre);
            Console.WriteLine("Metodo: " + m2.Metodos);
            Console.WriteLine("Propiedades: " + m2.Propiedades);
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + m3.Nombre);
            Console.WriteLine("Metodo: " + m3.Metodos);
            Console.WriteLine("Propiedades: " + m3.Propiedades);
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + p1.Nombre);
            Console.WriteLine("Metodo: " + p1.Metodos);
            Console.WriteLine("Propiedades: " + p1.Propiedades);
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + p2.Nombre);
            Console.WriteLine("Metodo: " + p2.Metodos);
            Console.WriteLine("Propiedades: " + p2.Propiedades);
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + p3.Nombre);
            Console.WriteLine("Metodo: " + p3.Metodos);
            Console.WriteLine("Propiedades: " + p3.Propiedades);
            
        }
    }
}
