using System;

namespace BasicO_N_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[100];
            Random random = new Random();
            for(int i=0;i<myArray.Length;i++)
            {
                myArray[i] = random.Next(1, 23456);
            }
            int output=myArray[0];

            //O(N), Find Greatest Number
            #region
            for (int i=1;i<myArray.Length;i++)
            {
                if (myArray[i] > output)
                    output = myArray[i];
                else
                {
                    continue;
                }
            }
            #endregion

            Console.WriteLine($"Greatest Number is: {output}");
        }
    }
}
