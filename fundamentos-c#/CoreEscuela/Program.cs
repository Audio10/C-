using System;

namespace CoreEscuela
{
    class Escuela
    {
        public string Name;
        public string direction;
        public int foundationYear;
        public string ceo;
        public void Timbrar()
        {
            // todo
            Console.Beep(1000,3000);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var miEscuela = new Escuela();
            miEscuela.Name = "Cr 9 calle 72";
            miEscuela.direction = "direccion 1";
            miEscuela.foundationYear = 2012;
            Console.WriteLine("Timbrando");
            miEscuela.Timbrar();
        }
    }
}
