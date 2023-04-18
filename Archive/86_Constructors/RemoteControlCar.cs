using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("86_Constructors.Tests")]

namespace _86_Constructors
{
    internal class RemoteControlCar
    {
        private int _speed; 
        private int _batteryDrain;
        private int _currentBatteryLevel = 100;
        private int _distance = 0;

        public RemoteControlCar(int speed, int batterDrain)
        {
            _speed = speed;
            _batteryDrain = batterDrain;
        }


        public bool BatteryDrained()
        {
            return _currentBatteryLevel < _batteryDrain;
        }

        public int DistanceDriven()
        {
            return _distance;
        }

        public void Drive()
        {
            if (_currentBatteryLevel >= _batteryDrain)
            { 
                _distance += _speed;
                _currentBatteryLevel -= _batteryDrain;
            }

        }

        public static RemoteControlCar Nitro()
        {
            return new RemoteControlCar(50, 4);
        }
    }
}
