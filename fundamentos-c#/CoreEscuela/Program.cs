﻿using System;
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
      
      escuela.Cursos = new Curso[] {
        new Curso(){ Nombre = "101" },
        new Curso(){ Nombre = "201" },
        new Curso{ Nombre = "301" }
      };

      ImprimirCursosEscuela(escuela);
      
    }

    private static void ImprimirCursosEscuela(Escuela escuela)
    {
      WriteLine("============================");
      WriteLine("Cursos de la Escuela");
      WriteLine("============================");

      // si escuela no es null comprara si es cursos null
      if(escuela?.Cursos == null) return;
      
      foreach(var curso in escuela.Cursos)
      {
        WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
      }

    }

    private static void ImprimirCursosWhile(Curso[] arregloCursos)
    {
      int contador = 0;
      while (contador < arregloCursos.Length)
      {
        Console.WriteLine($"Nombre {arregloCursos[contador].Nombre  }, Id  {arregloCursos[contador].UniqueId}");
        contador++;
      }
    }

    private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
    {
      int contador = 0;
      do
      {
        Console.WriteLine($"Nombre {arregloCursos[contador].Nombre  }, Id  {arregloCursos[contador].UniqueId}");
        // contador++;
      }while (++contador < arregloCursos.Length);
    }

    private static void ImprimirCursosFor(Curso[] arregloCursos)
    {
      for (int i=0; i<arregloCursos.Length; i++)
      {
        Console.WriteLine($"Nombre {arregloCursos[i].Nombre  }, Id  {arregloCursos[i].UniqueId}");
      }
    }

    private static void ImprimirCursosForEach(Curso[] arregloCursos)
    {
      foreach(var Curso in arregloCursos)
      {
        Console.WriteLine($"Nombre {Curso.Nombre  }, Id  {Curso.UniqueId}");
      }
    }


  }
}
