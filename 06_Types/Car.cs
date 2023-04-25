namespace _06_Types
{
    public class RemoteControlCar
    {
        public string CurrentSponsor { get; private set; }
        public RemoteControlCarTelemetry Telemetry { get; }

        public RemoteControlCar()
        {
            Telemetry = new RemoteControlCarTelemetry(this);
        }

        public string GetSpeed() => currentSpeed.ToString();
        private void SetSpeed(Speed speed) => currentSpeed = speed;
        private Speed currentSpeed;

        public class RemoteControlCarTelemetry
        {
            private RemoteControlCar _remoteControlCar;
            public RemoteControlCarTelemetry (RemoteControlCar remoteControlCar)
            {
                _remoteControlCar = remoteControlCar;
            }

            public void Calibrate() {}
            public bool SelfTest() => true;
            
            public void ShowSponsor(string sponsorName) => SetSponsor(sponsorName);
            private void SetSponsor(string sponsorName) => _remoteControlCar.CurrentSponsor = sponsorName;
                
            public void SetSpeed(decimal amount, string unitsString)
            {
                SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
                if (unitsString == "cps")
                    speedUnits = SpeedUnits.CentimetersPerSecond;
                _remoteControlCar.SetSpeed(new Speed(amount, speedUnits));
            }
        }
    }
    enum SpeedUnits
    {
        MetersPerSecond,
        CentimetersPerSecond
    }

    struct Speed
    {
        public decimal Amount { get; }
        public SpeedUnits SpeedUnits { get; }

        public Speed(decimal amount, SpeedUnits speedUnits)
        {
            Amount = amount;
            SpeedUnits = speedUnits;
        }
        public override string ToString()
        {
            string unitsString = "meters per second";
            if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
                unitsString = "centimeters per second";
            return Amount + " " + unitsString;
        }
    }
}
