





namespace RedRemoteControlCarTeam
{
    internal class RemoteControlCar : _05_Namespaces.RemoteControlCar
    {
        private RedRemoteControlCarTeam.Motor motor;
        private RedRemoteControlCarTeam.Chassis chassis;
        private RedRemoteControlCarTeam.Telemetry telemetry;
        private RedRemoteControlCarTeam.RunningGear runningGear;

        public RemoteControlCar( Motor motor, Chassis chassis, Telemetry telemetry, RunningGear runningGear)
        {
            this.motor = motor;
            this.chassis = chassis;
            this.telemetry = telemetry;
            this.runningGear = runningGear;
        }
    }
}