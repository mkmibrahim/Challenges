namespace _13_Param
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class RemoteControlCar
    {
        private int batteryPercentage = 100;
        private int distanceDrivenInMeters = 0;
        private string[] sponsors = new string[0];
        private int latestSerialNum = 0;

        public void Drive()
        {
            if (batteryPercentage > 0)
            {
                batteryPercentage -= 10;
                distanceDrivenInMeters += 2;
            }
        }

        public void SetSponsors(params string[] sponsorsInp)
        {
            sponsors = new string[sponsorsInp.Length];
            for(int i = 0; i < sponsorsInp.Length; i++)
            {
                sponsors[i] = sponsorsInp[i];
            }
        }

        public string DisplaySponsor(int sponsorNum)
        {
            return sponsors[sponsorNum];
        }

        public bool GetTelemetryData(ref int serialNum,
            out int batteryPercentageOut, out int distanceDrivenInMetersOut)
        {
            if (serialNum > latestSerialNum)
            {
                latestSerialNum = serialNum;
                batteryPercentageOut = batteryPercentage;
                distanceDrivenInMetersOut = distanceDrivenInMeters;
                return true;
            }
            else
            {
                serialNum = latestSerialNum;
                batteryPercentageOut = -1;
                distanceDrivenInMetersOut = -1;
                return false;
            }
        }

        public static RemoteControlCar Buy()
        {
            return new RemoteControlCar();
        }
    }

    public class TelemetryClient
    {
        private RemoteControlCar car;

        public TelemetryClient(RemoteControlCar car)
        {
            this.car = car;
        }

        public string GetBatteryUsagePerMeter(int serialNum)
        {
            if (car.GetTelemetryData(ref serialNum, out int batteryPercentage, out int distanceDrivenInMeters) &&
                distanceDrivenInMeters > 0)
            {
                var usagePerMeter = (100 - batteryPercentage)/ distanceDrivenInMeters;
                return $"usage-per-meter={usagePerMeter}";
            }
            else
                return "no data";
        }
    }

}