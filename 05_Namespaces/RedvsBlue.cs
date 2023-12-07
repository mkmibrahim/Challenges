using _05_Namespaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Namespaces
//public static class RedRemoteControlCarTeam
{
    public class RemoteControlCar
    {
        public RemoteControlCar(Motor motor, Chassis chassis, Telemetry telemetry, RunningGear runningGear)
        {
        }
        // red members and API
    }

    public class RunningGear
    {
        // red members and API
    }

    public class Telemetry
    {
        // red members and API
    }

    public class Chassis
    {
        // red members and API
    }

    public class Motor
    {
        // red members and API
    }
}

namespace BlueRemoteControlCarTeam
//public static class BlueRemoteControlCarTeam
{
    public class RemoteControlCar
    {
        public RemoteControlCar(Motor motor, Chassis chassis, Telemetry telemetry)
        {
        }
        // blue members and API
    }

    public class Telemetry
    {
        // blue members and API
    }

    public class Chassis
    {
        // blue members and API
    }

    public class Motor
    {
        // blue members and API
    }
}


namespace Combined
{
    public static class CarBuilder
    {
        public static RemoteControlCar BuildRed()
        {
            return new RedRemoteControlCarTeam.RemoteControlCar(
                new RedRemoteControlCarTeam.Motor(),
                new RedRemoteControlCarTeam.Chassis(),
                new RedRemoteControlCarTeam.Telemetry(),
                new RedRemoteControlCarTeam.RunningGear()
            );
        }

        public static BlueRemoteControlCarTeam.RemoteControlCar BuildBlue()
        {
            return new BlueRemoteControlCarTeam.RemoteControlCar(
                new BlueRemoteControlCarTeam.Motor(),
                new BlueRemoteControlCarTeam.Chassis(),
                new BlueRemoteControlCarTeam.Telemetry()
            );
        }
    }
}

namespace RedRemoteControlCarTeam
{
    public class Motor
    {
    }

    public class Chassis
    {
    }

    public class Telemetry
    {
    }

    public class RunningGear
    {
    }
}
