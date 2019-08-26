using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012);
            escuela.Country = "Colombia";
            escuela.City = "Bogota";
            Console.WriteLine(escuela.Name);
            Console.WriteLine(escuela.CreatedYear);
        }
    }
}
