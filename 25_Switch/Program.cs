using System.Xml.Linq;

namespace _25_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public static class PlayAnalyzer
    {
        

        public static string AnalyzeOnField(int shirtNum) => shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 or 4 => "center back",
            5 => "right back",
            6 or 7 or 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => throw new ArgumentOutOfRangeException(),
        };
        

        public static string AnalyzeOffField(object report)
        {
            switch (report)
            {
                case int numberOfSupporters:
                    return $"There are {numberOfSupporters} supporters at the match.";
                case string minutesMessage:
                    return minutesMessage;
                case Foul:
                    return "The referee deemed a foul.";
                case Injury injury:
                    return $"Oh no! {injury.GetDescription()} Medics are on the field.";
                case Manager manager:
                    return GetManagerDesription(manager);
                default:
                    throw new ArgumentException();
            };
        }

         private static string GetManagerDesription(Manager manager) => 
            manager.Club == null ? manager.Name : $"{manager.Name} ({manager.Club})";
    }

    public class Manager
        {
            public string Name { get; }

            public string? Club { get; }

            public Manager(string name, string? club)
            {
                this.Name = name;
                this.Club = club;
            }
        }

        public class Incident
        {
            public virtual string GetDescription() => "An incident happened.";
        }

        public class Foul : Incident
        {
            public override string GetDescription() => "The referee deemed a foul.";
        }

        public class Injury : Incident
        {
            private readonly int player;

            public Injury(int player)
            {
                this.player = player;
            }

            public override string GetDescription() => $"Player {player} is injured.";
        }

}