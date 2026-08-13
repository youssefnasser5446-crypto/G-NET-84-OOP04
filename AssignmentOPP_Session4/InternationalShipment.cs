using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOPP_Session4
{
    public class InternationalShipment : Shipment,ITrackable,IInsurable
    {
        string destinationCountry = "";
        decimal customsFee;
        public InternationalShipment()
        {

        }
        public string GetTrackingStatus()
        {
            return $"Shipment SH003 has been Delivered.";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
        public InternationalShipment(string? _trackingCode, string _description, decimal _weight, decimal _deliveryFee
           , string? _destinationCountry, decimal _customsFee) :
            base(_trackingCode, _description, _weight, _deliveryFee)
        {
            DestinationCountry = _destinationCountry ?? "";
            CustomsFee = _customsFee;
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Generating international customs report...");
        }


        public string DestinationCountry
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
            get
            {
                return destinationCountry;
            }
        }
        public decimal CustomsFee
        {
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
            get
            {
                return customsFee;
            }
        }
        public override decimal EstimatedCost  {get=>DeliveryFee + Weight * 5 + CustomsFee;}
        public override void PrintShipment()
        {
            Console.WriteLine($" trackingCode : {TrackingCode}\n " +
                $"description  : {Description} \n " +
                $" weight : {Weight}\n    deliveryFee : {DeliveryFee}  \n DestinationCountry : {DestinationCountry} \n" +
                $"CustomsFee : {CustomsFee} \n Estimated Cost : {EstimatedCost}");
        }

    }
}
