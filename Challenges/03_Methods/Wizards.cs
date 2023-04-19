using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Methods
{
    internal class Wizards
    {
    }

    public static class GameMaster
    {
        public static string Describe(Character character) => 
            $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points."; 

        public static string Describe(Destination destination) => 
            $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";

        public static string Describe(TravelMethod travelMethod) => travelMethod switch
        {
           TravelMethod.Walking => $"You're traveling to your destination by {travelMethod.ToString().ToLower()}.",
           TravelMethod.Horseback => $"You're traveling to your destination on {travelMethod.ToString().ToLower()}.",
        };
            

        public static string Describe(Character character, Destination destination, TravelMethod travelMethod) => 
            $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points. " +
                $"You're traveling to your destination on {travelMethod.ToString().ToLower()}. " +
                $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";

        public static string Describe(Character character, Destination destination) =>
            $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points. " +
                $"You're traveling to your destination by {TravelMethod.Walking.ToString().ToLower()}. " +
                $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
    }

    public class Character
    {
        public string Class { get; set; }
        public int Level { get; set; }
        public int HitPoints { get; set; }
    }

    public class Destination
    {
        public string Name { get; set; }
        public int Inhabitants { get; set; }
    }

    public enum TravelMethod
    {
        Walking,
        Horseback
    }

}
