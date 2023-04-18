// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var knightIsAwake = true;
QuestLogic.CanFastAttack(knightIsAwake);

//var knightIsAwake = false;
var archerIsAwake = true;
var prisonerIsAwake = false;
QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);
// => true

archerIsAwake = false;
prisonerIsAwake = true;
QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);
// => true

knightIsAwake = false;
archerIsAwake = true;
prisonerIsAwake = false;
var petDogIsPresent = false;
QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);
// => false

public class QuestLogic
{
    static public bool CanFastAttack(bool isAwake)
    {
        return !isAwake;
    }

    static public bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(prisonerIsAwake | knightIsAwake| archerIsAwake) 
        {
                return true;
        }
        return false;
    }

    static public bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (prisonerIsAwake & !archerIsAwake)
            return true;
        else
            return false;
    }

    static public bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, 
        bool petDogIsPresent)
    {
        if ( petDogIsPresent && !archerIsAwake)
            return true;
        else if (!petDogIsPresent & prisonerIsAwake & !archerIsAwake & !knightIsAwake)
            return true;
        else
            return false;
    }
}