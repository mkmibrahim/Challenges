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

        public bool IsAllergicTo(Allergen allergen) => (_allergies & (1 << (int)allergen) ) != 0;

        public Allergen[] List()
        {
            var AllergenValues = Enum.GetValues(typeof(Allergen));
            var result = AllergenValues.Cast<Allergen>()
                .Where(value => IsAllergicTo(value));
            return result.ToArray();
        }
    }
}