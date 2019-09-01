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

```c#
Coleccion.AddRange(otraColeccion);
```

#### Clear
Para eliminar todos los métodos de una colección usamos **Clear**

```c#
Coleccion.Clear();
```

#### Remove
Remover por objeto usamos **Remove**, esto sirve porque el compilador busca el objeto por su **HashCode**

```c#
Coleccion.Remove(obj);
```

#### HasCode
Mostrar el *HashCode*

```c#
Objeto.GetHashCode();
```

#### RemoveAll
El método **RemoveAll** pide como parámetro un **Predicate** (*Predicado*) el cual es una función que solamente va a regresar valores **Bool** y se va a ejecutar en cada elemento de la colección, de igual forma la función va a recibir como parámetro un elemento de la colección y en caso de que la condición regrese un valor de true entonces el objeto se va a borrar.

```c#
//El predicate<Curso> se puede eliminar ya que existe la inferencia de tipos y se puede
//declarar directamente el llamado en el RemoveAll(Predicate)

Predicate<Curso> miAlgoritmo  =  Predicate;
escuela.Cursos.RemoveAll(miAlgoritmo);
```


​		

```c#
private  static  bool  Predicate(Curso  curobj){
	return  curobj.Nombre  ==  "301";
}
```


En si la función **RemoveAll** manda como parámetro una función por cada uno de los cursos que están en la lista y a este se le denomina **Preducate** (*Predicado*)

**Delegado** especifica que parámetros de entrada y salida debe tener una función y se asegura de que se cumpla.

*Predicado por medio de **delegate**.*

```c#
escuela.Cursos.RemoveAll(delegate (Curso  cur)
{
return  cur.Nombre  ==  "301";
});
```
*Predicado por medio de **lambda**.*

```c#
escuela.Cursos.RemoveAll( (Curso  cur) =>  cur.Nombre  =="502");
```

#### OrderBy

Para ordenar una colección en este caso una lista se ocupa el **OrderBy**, este lleva un delegado que en este caso dice, que por cada alumno va a ordenar por el id.

```c#
var foo = listaAlumnos.OrderBy( (alumno) => alumno.UniqueId);
```



#### Take 

Toma una cantidad de elementos de una colección alumnos en este caso y la extrae.

```c#
var foo = listaAlumnos.OrderBy( (alumno) => alumno.UniqueId).Take(cantidad);
```

#### ToList

Convierte un objeto a una lista.

```c#
var foo = listaAlumnos.OrderBy( (alumno) => alumno.UniqueId).Take(cantidad).ToList();
```



### Linq

Linq es un lenguaje lenguaje integrado de consultas, que se genero cuando se dieron cuenta que la gente gasta mucho tiempo en generar estructuras para consultar datos. Podemos utilizarlo para hacer un producto cartesiano, es decir un todo contra todos declarativamente.

```
string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };

string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
      
string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

var listaAlumnos = from n1 in nombre1
                   from n2 in nombre2
                   from a1 in apellido1
                   select new Alumno { Nombre = $"{n1} {n2} {a1}" };
```

## Herencia.

Concepto básico de programación Orientada a Objetos, donde un objeto hereda campos y métodos a otro objeto.

La forma de establecer una Herencia es donde **Curso**, hereda de **ObjetoEscuelaBase**:

```c#
Curso: ObjetoEscuelaBase
```

Al momento de programar nuestras clases padre podemos usar la palabra clave **abstract** para que dicha clase solamente pueda ser heredada, pero nunca instanciada. 

Por el contrario, tenemos la palabra clave **sealed** permite generar instancias de la clase, pero no permite heredarla. Con esta palabra clave sellas la instancia.

```c#
public sealed class EscuelaEngine
```

