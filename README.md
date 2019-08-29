# C#

## Short cuts 

> CTRL + .
Sirve para importar librerías necesarias.

## Comentarios.

 -  Con  `//`  para comentar una sola línea.
 -  Con  `/*`  y  `*/`  para comentar varias líneas.
 -  Con  `///`  para comentar lo que hace un método especifico.
 
## Implementando colecciones.

Las colecciones se encuentran almacenadas en **System.Collections**  donde puedes encontrar las variantes de estas mismas tales como.

 - Generic
 - Specialized
 - etc.

Al ocupar un tipo de **collection genérica** este se debe optimizar para ser usado por un tipo de dato en especifico, esto se especifica dentro de **<>**.

### Métodos de colecciones.


#### AddRange
El método **AddRange** adiciona una colección a otra.

    Coleccion.AddRange(otraColeccion);

#### Clear
Para eliminar todos los métodos de una colección usamos **Clear**

    Coleccion.Clear();

#### Remove
Remover por objeto usamos **Remove**, esto sirve porque el compilador busca el objeto por su **HashCode**

    Coleccion.Remove(obj);

#### HasCode
Mostrar el *HashCode*

    Objeto.GetHashCode();

#### RemoveAll
El método **RemoveAll** pide como parámetro un **Predicate** (*Predicado*) el cual es una función que solamente va a regresar valores **Bool** y se va a ejecutar en cada elemento de la colección, de igual forma la función va a recibir como parámetro un elemento de la colección y en caso de que la condición regrese un valor de true entonces el objeto se va a borrar.

    //El predicate<Curso> se puede eliminar ya que existe la inferencia de tipos y se puede
    //declarar directamente el llamado en el RemoveAll(Predicate)
    
    Predicate<Curso> miAlgoritmo  =  Predicate;
    escuela.Cursos.RemoveAll(miAlgoritmo);

		

    private  static  bool  Predicate(Curso  curobj){
		return  curobj.Nombre  ==  "301";
	}


En si la función **RemoveAll** manda como parámetro una función por cada uno de los cursos que están en la lista y a este se le denomina **Preducate** (*Predicado*)

**Delegado** especifica que parámetros de entrada y salida debe tener una función y se asegura de que se cumpla.

*Predicado por medio de **delegate**.*

    escuela.Cursos.RemoveAll(delegate (Curso  cur)
	{
	return  cur.Nombre  ==  "301";
	});
*Predicado por medio de **lambda**.*

    escuela.Cursos.RemoveAll( (Curso  cur) =>  cur.Nombre  =="502");