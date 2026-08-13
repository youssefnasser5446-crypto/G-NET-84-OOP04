using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOPP_Session4
{
    public abstract class Shipment
    {
        
        private string? trackingCode;
        private string? description;
        private decimal weight;
        private decimal deliveryFee;

        public Shipment()
        {

        }
        public Shipment(string? _trackingCode)
        {
            if (!string.IsNullOrWhiteSpace(_trackingCode))
            {
                TrackingCode = _trackingCode;
            }
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            
        }
        public Shipment(string? _trackingCode, string _description, decimal _weight, decimal _deliveryFee)
        {
            if (!string.IsNullOrWhiteSpace(_trackingCode))
            {
                TrackingCode = _trackingCode;
            }
            Description = _description;
            Weight = _weight;
            DeliveryFee = _deliveryFee;
        }
        public Shipment(string? _trackingCode, string _description, decimal _weight, decimal _deliveryFee, DeliveryAddress _destination)
            : this(_trackingCode, _description, _weight, _deliveryFee)
        {
            Destination = _destination;
            
        }
        public abstract decimal EstimatedCost { get; }

        public abstract void PrintShipment();
        public DeliveryAddress? Destination { set; get; }

        public string TrackingCode
        {
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }

            get
            {
                if (!string.IsNullOrWhiteSpace(trackingCode))
                    return trackingCode;
                else
                    return "";
            }
        }
        public string Description
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
            get
            {
                if (description is not null)
                    return description;
                else
                    return "no description";
            }
        }
        public decimal Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }

            get
            {
                return weight;
            }
        }

        public decimal DeliveryFee
        {
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
            get
            {
                return deliveryFee;
            }
        }     
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                deliveryFee = newFee;
        }
        
        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                weight = newWeight;
            }

        }

        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            if (newWeight > 0 && packingWeight >= 0)
            {
                weight = newWeight + packingWeight;
            }

        }
    }
}
