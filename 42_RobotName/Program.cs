

using System.Text;

namespace _42_RobotName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class RobotName
    {
        const int robotsCount = 10_000;
        public static List<string> names = new List<string>(robotsCount);
    }

    public class Robot
    {
        string _name;
        

        public string Name
        {
            get
            {
                if (_name == null)
                {
                    Reset();
                    while (RobotName.names.Contains(_name))
                    {
                        Reset() ;
                    }
                    RobotName.names.Add(_name);
                }
                return _name;
            }
        }

        public void Reset()
        {
            char[] lettersAvailable = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
            char[] numbersAvailable = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

            StringBuilder randomName = new StringBuilder();

            Random randomCharacter = new Random();

            int randomCharSelected = randomCharacter.Next(0, (lettersAvailable.Length));
            randomName.Append(lettersAvailable[randomCharSelected]);
            
            randomCharSelected = randomCharacter.Next(0, (lettersAvailable.Length));
            randomName.Append(lettersAvailable[randomCharSelected]);

            randomCharSelected = randomCharacter.Next(0, numbersAvailable.Length - 1);
            randomName.Append(numbersAvailable[randomCharSelected]);

            randomCharSelected = randomCharacter.Next(0, numbersAvailable.Length - 1);
            randomName.Append(numbersAvailable[randomCharSelected]);
            
            randomCharSelected = randomCharacter.Next(0, numbersAvailable.Length - 1);
            randomName.Append(numbersAvailable[randomCharSelected]);

            _name = randomName.ToString();
        }
    }
}