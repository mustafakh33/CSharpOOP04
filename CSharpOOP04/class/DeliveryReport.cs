using CSharpOOP04.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP04
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance():C}");
        }
    }
}
