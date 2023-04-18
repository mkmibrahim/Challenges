namespace _98_Interfaces
{
    public interface IRemoteControlCar 
    {
        int DistanceTravelled {get;}
        void Drive();
    }

    public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
    {
        public int DistanceTravelled { get; private set; }
        public int NumberOfVictories { get; set; }

        public void Drive() => DistanceTravelled += 10;

        public int CompareTo(ProductionRemoteControlCar? other)
        {
            if (other == null) throw new ArgumentNullException();
            return this.NumberOfVictories.CompareTo(other.NumberOfVictories);
        }
    }

    public class ExperimentalRemoteControlCar :IRemoteControlCar
    {
        public int DistanceTravelled { get; private set; }

        public void Drive() => DistanceTravelled += 20;
    }

    public static class TestTrack
    {
        public static void Race(IRemoteControlCar car) => car.Drive();

        public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
            ProductionRemoteControlCar prc2)
        {
            List<ProductionRemoteControlCar> result = new List<ProductionRemoteControlCar>() {prc1, prc2};
            result.Sort();
            return result;
            //return new[] { prc1, prc2 }.OrderByDescending(x => x).ToList();
        }
    }

}
