using System.Buffers.Text;
using System.ComponentModel;
using System.Xml.Linq;

namespace FactoryPattern
//    Create an Interface named IVehicle that has a stubbed out public void Drive method.
//Create 2 new public classes that will conform to IVehicle.
//Example) Car, Motorcycle, BigRig
//Note: These classes must conform to IVehicle and implement the Drive() method -
//which will just Console.WriteLine(“Building a new Car!”)

//Now we will make our static VehicleFactory class.
//It will contain a static method GetVehicle(), that will return an IVehicle based on the
//amount of tires it’s given as a parameter
//Call this functionality in the Main method.
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool trueOrFalse = true;
            while (trueOrFalse)
            {
                Console.WriteLine("How many tires do you want on your vehicle?");

                var userValue = Console.ReadLine();
                int inputValue;

                bool success = int.TryParse(userValue, out inputValue);

                if (success)
                {

                    Ivehicle vehicle = VehicleFactory.GetVehicle(inputValue);

                    vehicle.Drive();

                    trueOrFalse = false;

                }

                else 
                { 
                    Console.WriteLine("Please enter a valid integer for tires.");
                    Console.WriteLine();
                }
            }

            

        }
    }
}
