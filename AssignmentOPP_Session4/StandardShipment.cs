using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOPP_Session4
{
    public class StandardShipment:Shipment,ITrackable,IInsurable
    {
        public StandardShipment()
        {
            
        }
        public StandardShipment(string? _trackingCode, string _description, decimal _weight, decimal _deliveryFee) : base(_trackingCode, _description, _weight, _deliveryFee)
        {

        }
        public override decimal EstimatedCost
        { 
            get => DeliveryFee + (Weight* 5);      
        }
       public string GetTrackingStatus()
        {
            return $"Shipment SH001 is Ready.";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($" trackingCode : {TrackingCode}\n " +
                $"description  : {Description} \n " +
                $" weight : {Weight}\n    deliveryFee : {DeliveryFee}\n EstimatedCost : {EstimatedCost} "); 
        }
    }
}
