using System;

class Estudiante
{
    // Propiedades de la clase Estudiante
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }

    // Método para mostrar la información del estudiante
    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: {0}, Edad: {1}, Calificación: {2}", Nombre, Edad, Calificacion);
    }
}

// Clase que hereda de Estudiante
class EstudianteGraduado : Estudiante
{
    // Nueva propiedad para EstudianteGraduado
    public string Titulo { get; set; }
}

class Program
{
    static void Main()
    {
        // Ejercicio 1: Variables y Operadores en C#
        Console.WriteLine("Ejercicio 1: Variables y Operadores en C#");
        int numero1 = 10;
        int numero2 = 5;
        int resultado = numero1 + numero2;
        Console.WriteLine("La suma de {0} y {1} es: {2}", numero1, numero2, resultado);
        Console.WriteLine();

        // Ejercicio 2: Estructuras de Control en C#
        Console.WriteLine("Ejercicio 2: Estructuras de Control en C#");
        int edad = 23;
        if (edad >= 18)
        {
            Console.WriteLine("La persona es mayor de edad.");
        }
        else
        {
            Console.WriteLine("La persona NO es mayor de edad.");
        }
        Console.WriteLine();

        // Ejercicio 3: Programación Orientada a Objetos - Clases y Objetos
        Console.WriteLine("Ejercicio 3: Programación Orientada a Objetos - Clases y Objetos");
        Estudiante estudiante1 = new Estudiante
        {
            Nombre = "Aracelly",
            Edad = 20,
            Calificacion = 85.5
        };
        Console.WriteLine("Nombre: {0}, Edad: {1}, Calificación: {2}", estudiante1.Nombre, estudiante1.Edad, estudiante1.Calificacion);
        Console.WriteLine();

        // Ejercicio 4: Programación Orientada a Objetos - Métodos
        Console.WriteLine("Ejercicio 4: Programación Orientada a Objetos - Métodos");
        estudiante1.MostrarInformacion();
        Console.WriteLine();

        // Ejercicio 5: Programación Orientada a Objetos - Herencia
        Console.WriteLine("Ejercicio 5: Programación Orientada a Objetos - Herencia");
        EstudianteGraduado graduado1 = new EstudianteGraduado
        {
            Nombre = "Lisa",
            Edad = 25,
            Calificacion = 92.3,
            Titulo = "Licenciatura en Informática"
        };
        graduado1.MostrarInformacion();
        Console.WriteLine("Título obtenido: {0}", graduado1.Titulo);
    }
}
