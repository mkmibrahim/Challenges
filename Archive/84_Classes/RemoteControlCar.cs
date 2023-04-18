using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("84_Classes.Tests")]

namespace _84_Classes
{
    internal class RemoteControlCar
    {
        int distanceDriven = 0;
        int batteryPercentage = 100;
        public static RemoteControlCar Buy()
        {
            return new RemoteControlCar();
        }

        public string DistanceDisplay()
        {
            var result = $"Driven {distanceDriven} meters" ;
            return result;
        }

        public string BatteryDisplay()
        {
            var result = batteryPercentage > 0 ? $"Battery at {batteryPercentage}%" : "Battery empty";
            return result;
        }

        public void Drive()
        {
            if (batteryPercentage > 0)
            { 
                distanceDriven += 20;
                batteryPercentage--;
            }
        }
    }
}
