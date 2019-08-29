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
        new Curso{ Nombre = "502" , Jornada = TiposJornada.Tarde}
      };
      
      // otraColeccion.Clear();
      escuela.Cursos.AddRange(otraColeccion);

      Predicate<Curso> miAlgoritmo = Predicate;
      escuela.Cursos.RemoveAll(miAlgoritmo);
      ImprimirCursosEscuela(escuela);

    }

    private static bool Predicate(Curso curobj)
    {
      return curobj.Nombre == "301";
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
