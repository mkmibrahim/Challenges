using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("86_Constructors.Tests")]

namespace _86_Constructors
{
    internal class RaceTrack
    {
        private int _distance;
        
        internal RaceTrack (int distance)
        {
            _distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car)
        {
            while (car.DistanceDriven() < _distance & !car.BatteryDrained())
            {
                car.Drive();

            }
            return car.DistanceDriven() >= _distance;
        }
    }
}
