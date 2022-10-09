using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    //La clase normal representa un tipo de driver 
    //que solo es capaz de llevar  a una persona.
    public class Normal : Driver
    {
        public Normal(string firstname, string lastname, string ci, Vehicle vehicle, String bio, string path)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.CI = ci;
            this.Vehicle = vehicle;
            this.Bio = bio;

            UploadToTwitter(path);
        }


    }

}