using System;
using Etapa1.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,City:"Bogota");
            escuela.Country = "Colombia";
            escuela.City = "Bogota";
            // //Enumerador
            // escuela.TipoEscuela = TiposEscuela.Primaria;
            Curso curso1 = new Curso(){
                Nombre = "101"
            };

            Curso curso2 = new Curso(){
                Nombre = "201"
            };

            Curso curso3 = new Curso(){
                Nombre = "301"
            };

            Console.WriteLine(escuela);
            System.Console.WriteLine("===============");
            Console.WriteLine(curso1.Nombre + "," + curso1.UniqueId);
            Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
            Console.WriteLine(curso3);
        }
    }
}
