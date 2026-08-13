using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AssignmentOPP_Session4
{
    public class DeliveryCenter
    {
        private Shipment[] shipment;
        private int count;
        public Driver? Driver { get; set; }
        //  private string? CenterName;
        public DeliveryCenter()
        {
            shipment = new Shipment[20];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return shipment[index];
                }
                return default!;
            }
            set
            {
                if (index >= 0 && index < shipment.Length)
                {
                    shipment[index] = value;
                }
            }
        }

        public Shipment this[string index]
        {
            get
            {
                for (int i = 0; i < shipment.Length; i++)
                {
                    if (index is not null && index.Equals(shipment[i]?.TrackingCode))
                    {
                        return shipment[i];

                    }
                }
                return default!;
            }
        }
        public bool AddShipment(Shipment ship)
        {

            if (count < shipment.Length)
            {
                shipment[count] = ship;
                count++;
                return true;
            }
            return false;
        }
        public bool RemoveShipment(string code)
        {

            for (int i = 0; i < shipment.Length; i++)
            {
                if (code == shipment[i]?.TrackingCode)
                {

                    for (int j = i; j < count - 1; j++)
                    {
                        shipment[j] = shipment[j + 1];
                    }
                    shipment[count - 1] = null!;
                    count--;
                    return true;

                }
            }
            return false;
        }
        public void PrintAllShipments()
        {
            for (int i = 0; i < count; i++)
            {
                shipment[i].PrintShipment();               
            }
        }
        
        public void PrintTrackingStatuses()
        {
            foreach(ITrackable x in shipment)
            {
                if (x is not null)
                    Console.WriteLine(x.GetTrackingStatus());

            }
        }

        

    }
}
