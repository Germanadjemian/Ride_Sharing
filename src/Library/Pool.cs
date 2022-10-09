using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    //La clase Pool representa un tipo de driver 
    //que puede llevar mas de una persona, respentando la capacidad máxima del vehículo.
    public class Pool : Driver
    {

        public Pool(string firstname, string lastname, string ci, Vehicle vehicle, String bio, string path)
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
