using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOPP_Session4
{
    static public class DeliveryHelper
    {
        static public void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
                shipment.PrintShipment();

        }
    }
}
