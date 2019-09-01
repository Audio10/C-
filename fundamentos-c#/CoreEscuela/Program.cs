using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela
{
  class Program
  {
    static void Main(string[] args)
    {
      var engine = new EscuelaEngine();
      engine.Inicializar();
      Printer.WriteTitle("Bienvenidos a la escuela ");
      ImprimirCursosEscuela(engine.Escuela);

      Printer.DrawLine(20);
      Printer.DrawLine(20);
      Printer.DrawLine(20);
      Printer.WriteTitle("Pruebas de Polimorfismo");
      
    }

    private static void ImprimirCursosEscuela(Escuela escuela)
    {
      
      Printer.WriteTitle("Cursos de la Escuela");

      // si escuela no es null comprara si es cursos null
      if (escuela?.Cursos == null) return;

      foreach (var curso in escuela.Cursos)
      {
        WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
      }

    }

  }
}
