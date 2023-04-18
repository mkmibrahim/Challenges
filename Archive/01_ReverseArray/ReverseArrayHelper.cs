using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReverseArray
{
    public class ReverseArrayHelper
    {
        public static int[] ReverseValues(int[] arr)
        {
            //int[] varArrayReversed = new int[arr.Length];
            //var y = 0;
            //var z = 0;
            //while (y < arr.Length)
            //{
            //    //if (arr[arr.Length - 1 - y] != null)
            //    //{
            //    varArrayReversed[z] = (arr[arr.Length - 1 - y]);
            //    z++;
            //    //}

            //    y++;
            //}
            //for (int x = 0; x < arr.Length; x++)
            //{
            //    arr[x] = varArrayReversed[x];
            //}

            // -----
            //int[] varArrayReversed = new int[arr.Length];
            //var y = 0;
            //while (y < arr.Length)
            //{
            //    varArrayReversed[y] = (arr[arr.Length - 1 - y]);
            //    y++;
            //}
            //for (int x = 0; x < arr.Length; x++)
            //{
            //    arr[x] = varArrayReversed[x];
            //}
            Array.Reverse(arr);

            return arr;
        }
    }
}
