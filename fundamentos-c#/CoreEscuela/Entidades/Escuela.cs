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
    public TiposEscuela TipoEscuela {get; set;}

    //Constructor
    // public Escuela(string name, int CreatedYear)
    // {
    //   this.name = name;
    //   this.CreatedYear = CreatedYear;
    // }

  //IGUALACION POR TUPLAS PROGRAMACION FUNCIONAL
  // (parametos) = > (entidades de la clase) = (parametros)
    public Escuela(string name, int year) => (Name, CreatedYear) = (name,year);
    public Escuela(string name,
                   int year,
                   TiposEscuela tipos,
                   string Country = "",
                   string City="")
    {
      (Name, CreatedYear) = (name, year);
      this.Country = Country;
      this.City = City;
    }

    public override string ToString()
    {
      // { System.Environment.NewLine} NUEVA LINEA ESTO ES PORQUE NO TODOS LOS CARACTERES SON LOS MISMOS EN TODOS LOS LUGARES.
      return $"\nNombre: \"{name}\" \nTipo: {TipoEscuela} {System.Environment.NewLine}Pais:{Country} \nCiudad: {City}";
    }
  }
}