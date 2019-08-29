using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
  class Program
  {
    static void Main(string[] args)
    {
      var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, City: "Bogota");
      escuela.Country = "Colombia";

      escuela.Cursos = new List<Curso>(){
        new Curso(){ Nombre = "101" , Jornada = TiposJornada.Mañana},
        new Curso(){ Nombre = "201" , Jornada = TiposJornada.Mañana},
        new Curso{ Nombre = "301" , Jornada = TiposJornada.Mañana}
      };

      escuela.Cursos.Add(new Curso() { Nombre = "102", Jornada = TiposJornada.Tarde });
      escuela.Cursos.Add(new Curso() { Nombre = "202", Jornada = TiposJornada.Tarde });

      var otraColeccion = new List<Curso>(){
        new Curso(){ Nombre = "401" , Jornada = TiposJornada.Mañana},
        new Curso(){ Nombre = "501" , Jornada = TiposJornada.Mañana},
        new Curso{ Nombre = "502" , Jornada = TiposJornada.Tarde},
        new Curso{ Nombre = "502" , Jornada = TiposJornada.Mañana}
      };
      
      // otraColeccion.Clear();
      escuela.Cursos.AddRange(otraColeccion);

      // Predicate<Curso> miAlgoritmo = Predicate;
      escuela.Cursos.RemoveAll(delegate (Curso cur)
                                        {
                                          return cur.Nombre == "301";
                                        });

      escuela.Cursos.RemoveAll( (Curso cur) => cur.Nombre =="502");

      ImprimirCursosEscuela(escuela);

    }

    private static void ImprimirCursosEscuela(Escuela escuela)
    {
      WriteLine("============================");
      WriteLine("Cursos de la Escuela");
      WriteLine("============================");

      // si escuela no es null comprara si es cursos null
      if (escuela?.Cursos == null) return;

      foreach (var curso in escuela.Cursos)
      {
        WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
      }

    }

  }
}
