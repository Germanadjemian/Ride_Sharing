namespace Library;
using System;


public abstract class Person
{
    // al ser Person una clase abstracta no tiene constructor
    // las properties firstname, lastname, CI y Calification son virtuales ya que que son las mismas para
    // todas las subclaes y por si es necesario sobre escribirlas en una de ellas
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual string CI { get; set; }
    public virtual List<double> Calification { get; }
    public double getCalificationAverage()
    {
        // retorna el promedio de las calificaciones con dos lugares decimales despues de la coma
        // el promedio no es virtual ni abstracto ya que el calculo es el mismo para todas las subclases

        return System.Math.Round(Calification.Average(), 2);

    }
    public virtual void addCalification(double calification)
    {
        // Agrega las calificaiones a la lista de calificaciones, 
        // este es un metodo virtual ya que puede ser que las sub clases lo tengan que sobre escribir  

        this.Calification.Add(calification);

    }
}