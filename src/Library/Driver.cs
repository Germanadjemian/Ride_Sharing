namespace Library;
using System;

public abstract class Driver: Person
{
    public string Bio {get; set;}
    public virtual Vehicle Vehicle { get; set; }
    public virtual void aceptar()
    {
        
    }
}