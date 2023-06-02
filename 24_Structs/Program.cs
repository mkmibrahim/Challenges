using System.Linq;

namespace _24_Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public struct Coord : IComparable<Coord>
    {
        public Coord(ushort x, ushort y)
        {
            X = x;
            Y = y;
        }

        public ushort X { get; }
        public ushort Y { get; }

        public int CompareTo(Coord other)
        {
            return X - other.X;
        }
    }

    public struct Plot
    {
        public Coord _coord1;
        private Coord _coord2;
        private Coord _coord3;
        private Coord _coord4;

        public Plot(Coord coord1, Coord coord2, Coord coord3, Coord coord4)
        {
            _coord1 = coord1;
            _coord2 = coord2;
            _coord3 = coord3;
            _coord4 = coord4;
        }
    }


    public class ClaimsHandler
    {
        private List<Plot> _claims = new List<Plot>();

        public void StakeClaim(Plot plot) => _claims.Add(plot);
        

        public bool IsClaimStaked(Plot plot) => _claims.Contains(plot);

        public bool IsLastClaim(Plot plot) => _claims.LastOrDefault().Equals(plot);

        public Plot GetClaimWithLongestSide() => _claims.MaxBy(c => c._coord1);
    }

}