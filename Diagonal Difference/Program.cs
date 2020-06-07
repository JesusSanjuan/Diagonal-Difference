using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {         
            List<List<int>> arr = new List<List<int>>()
            {   new List<int>(){11,2,4},
                new List<int>(){4,5,6},
                new List<int>(){10,8,-12}
            };

            int result = Result.diagonalDifference(arr);
            Console.Write(result);
            Console.Read();
        }       
    }

    class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            List<int> primarydiagonal = new List<int>();
            List<int> secundarydiagonal = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {

                }
            }
            return 0;
        }

    }
}
