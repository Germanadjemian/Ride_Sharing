// See https://aka.ms/new-console-template for more information
namespace Library;

class program
{
    public static void Main(string[] args)
    {

        List<Driver> driversList = new List<Driver>();
        List<Passenger> passengerList = new List<Passenger>();


        Vehicle lanave = new Vehicle(4);

        Passenger passenger = new Passenger("Nombre pasajero", "Apellido pasajero", "ci pasajero", "carlos.jpg");
        passengerList.Add(passenger);

        Pool pooldriver = new Pool("Nombre pool", "Apellido pool", "ci pool", lanave, "bio de conductor pool", "avion.jpg");
        driversList.Add(pooldriver);

        Pool normaldriver = new Pool("Nombre normal", "Apellido normal", "ci normal", lanave, "bio de conductor normal", "carlos.jpg");
        driversList.Add(normaldriver);



    }
}