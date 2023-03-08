using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _80_Arrays
{
    public class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        var result = new int[]{0, 2, 5, 3, 7, 8, 4};
        return result;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length-1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length-1]++;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Contains(0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var result = 0;
        for(int i= 0; i < numberOfDays; i++)
            {
                result += birdsPerDay[i];
            }
        return result;
    }

    public int BusyDays()
    {
        var result = 0;
        for(int i= 0; i < birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] > 4)
                {
                    result++;
                }
                //result = birdsPerDay[i] > 4 ? result++ : result;
            }
        return result;
    }
}

}
