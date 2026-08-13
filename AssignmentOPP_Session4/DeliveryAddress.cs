using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOPP_Session4
{
    public struct DeliveryAddress
    {

        public string? city;
        public string? street;
        public int BuildingNumber;

        public DeliveryAddress(string? _city, string? _Street, int _BuildingNumber)
        {
            city = _city;
            street = _Street;
            BuildingNumber = _BuildingNumber;
        }

        public string GetFullAddress()
        {
            return $"city : {city} \n street : {street}\n BuildingNumber :{BuildingNumber}";
        }

    }
}
