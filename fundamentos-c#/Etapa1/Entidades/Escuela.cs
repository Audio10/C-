namespace CoreEscuela.Entidades
{
  class Escuela
  {
    string name;
    // Encapsulamiento si se cambia algo
    public string Name
    {
      get { return "Copia: " + name; }
      set { name = value.ToUpper(); }
    }

    //Encapsulamiento si no se modifica nada
    public int CreatedYear { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    private int myVar;

    //Constructor
    // public Escuela(string name, int CreatedYear)
    // {
    //   this.name = name;
    //   this.CreatedYear = CreatedYear;
    // }

  //IGUALACION POR TUPLAS PROGRAMACION FUNCIONAL
  // (parametos) = > (entidades de la clase) = (parametros)
    public Escuela(string name, int year) => (Name, CreatedYear) = (name,year);

  }
}