using AssignmentOPP_Session4;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace Assignment_Session03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01

            /*
             a)  What is Abstraction in Object-Oriented Programming?

            ans => Abstraction means hiding complex implementation details and exposing only the essential features

            b)  Why is abstraction considered one of the four pillars of OOP?

            ans => Because it helps reduce complexity by hiding unnecessary implementation details 
            and exposing only the essential features

             */

            #endregion

            #region Question02

            /*
              
             a)  What is the difference between an Abstract Class and an Interface?

            ans => In an abstract class, you can define fields and mix regular methods with abstract ones;
            regarding inheritance, a subclass can inherit from only one abstract class. An interface,
            however, has no constructor; you can  include default, abstract, and static methods,
            and the fields allowed are constants—though a class can implement multiple interfaces.


              b)  When would you choose an Interface instead of an Abstract Class?

             ans =>  eI choose an interface when I want to define a contract that different,
            unrelated classes can implement, and when I need a class to implement multiple contracts.


            c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            No, a class cannot inherit from multiple abstract classes.
            Yes, a class can implement multiple interfaces.
             */

            #endregion

            StandardShipment standard = new StandardShipment("SH001", "Laptop", 3, 80);
            ExpressShipment Express = new ExpressShipment("SH002", "Mobile Phone", 2, 60, 30);
            InternationalShipment international = new InternationalShipment("SH003", "Televition", 8, 120, "Germany", 100);

            DeliveryCenter DC = new DeliveryCenter();
            Console.WriteLine(DC.AddShipment(standard) ? "Shipment Added Succssfully" : "Shipment Not Added");
            Console.WriteLine(DC.AddShipment(Express) ? "Shipment Added Succssfully" : "Shipment Not Added");
            Console.WriteLine(DC.AddShipment(international) ? "Shipment Added Succssfully" : "Shipment Not Added");

            Console.WriteLine("\n=======================================\n");

            Console.WriteLine("Standard Shipment\n");
            DeliveryHelper.PrintShipmentDetails(standard);
            Console.WriteLine("\n=======================================\n");

            Console.WriteLine("Express Shipment\n");
            DeliveryHelper.PrintShipmentDetails(Express);
            Console.WriteLine("\n=======================================\n");

            Console.WriteLine("International Shipment\n");
            DeliveryHelper.PrintShipmentDetails(international);
            Console.WriteLine("\n=======================================\n");

            Console.WriteLine("Tracking Status with interface array");

            ITrackable[] Track = { standard, Express, international };

            foreach(ITrackable x in Track)
            {
                Console.WriteLine(x.GetTrackingStatus());
            }
            
            IInsurable[] Insurable = { standard, Express, international };
            Console.WriteLine("\n=======================================\n");

            foreach (IInsurable x in Insurable)
            {
                if (x is StandardShipment )
                    Console.WriteLine($"Standard Shipment Insurance : {x.CalculateInsurance()} EGP");

                if (x is ExpressShipment )
                    Console.WriteLine($"Express Shipment Insurance : {x.CalculateInsurance()} EGP");

                if (x is InternationalShipment)
                    Console.WriteLine($"International Shipment Insurance : {x.CalculateInsurance()} EGP");
            }
            Console.WriteLine("\n=======================================\n");
            Console.WriteLine("\nTracking Status with DeliveryReport \n");

            DeliveryReport report = new DeliveryReport();
            report.PrintShipment(standard);
            report.PrintShipment(Express);
            report.PrintShipment(international);
            Console.WriteLine("\n=======================================\n");

            Console.WriteLine("\nPrint Insurance Status with DeliveryReport \n");
            Console.Write("Standard Shipment Insurance : "); report.PrintInsurance(standard); Console.Write(" EGP\n");
            Console.Write("Express Shipment Insurance : "); report.PrintInsurance(Express); Console.Write(" EGP\n");
            Console.Write("International Shipment Insurance : "); report.PrintInsurance(international); Console.Write(" EGP\n");


            Console.WriteLine("\n=======================================\n");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
        }
}
}
