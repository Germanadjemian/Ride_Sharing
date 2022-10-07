namespace Library;
using System;
public class Trip {
    public virtual Driver Driver { get; set; }
    public virtual List<Passanger> PassangerList { get; set; }

    public virtual void AddPasanger(Passanger p){
        PassangerList.Add(p);
    }

}