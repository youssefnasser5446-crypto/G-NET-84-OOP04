using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOPP_Session4
{
    public class ExpressShipment : Shipment,ITrackable,IInsurable
    {
        decimal extraFee;
        public ExpressShipment(string? _trackingCode, string _description, decimal _weight, decimal _deliveryFee, decimal _extraFee) : base(_trackingCode, _description, _weight, _deliveryFee)
        {
            ExtraFee = _extraFee;

        }
        public string GetTrackingStatus()
        {
            return $"Shipment SH002 is Out for Delivery.";
        }
       public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public override decimal EstimatedCost { get =>DeliveryFee + Weight * 5 + ExtraFee;  }
        public override void PrintShipment()
        {
            Console.WriteLine($" trackingCode : {TrackingCode}\n " +
                $"description  : {Description} \n " +
                $" weight : {Weight}\n    deliveryFee : {DeliveryFee}  \n ExtraFee : {ExtraFee} \n " +
                        $" Estimated cost : {EstimatedCost} "); 
        }

    }
}
