using System.Globalization;

namespace _43_Allergies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    
    public enum Allergen
    {
        Eggs,
        Peanuts,
        Shellfish,
        Strawberries,
        Tomatoes,
        Chocolate,
        Pollen,
        Cats
    }

    public class Allergies
    {
        int _allergies;

        public Allergies(int mask)
        {
            _allergies = mask;
        }

        public bool IsAllergicTo(Allergen allergen)
        {
            var result = (_allergies & (1 << (int)allergen) ) != 0;
            return result;
        }

        public Allergen[] List()
        {
            var result = new List<Allergen>();
            var AllergenValues = Enum.GetValues(typeof(Allergen));
            foreach (var item in AllergenValues)
            {
                if (IsAllergicTo((Allergen)item))
                    result.Add((Allergen)item);
            }
            return result.ToArray();
        }
    }
}