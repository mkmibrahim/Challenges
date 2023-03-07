// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var knightIsAwake = true;
QuestLogic.CanFastAttack(knightIsAwake);

//var knightIsAwake = false;
var archerIsAwake = true;
var prisonerIsAwake = false;
QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);
// => true

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
}