using System;
using System.Collections.Generic;

namespace competitiveProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int numOfYears = Convert.ToInt32(input);
            var finalPicture = new List<string>();
            while (true)
            {
                var pictureInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(pictureInput))
                {
                    break; //Break if the input is empty.
                }
                finalPicture.Add(pictureInput);
            }
        }
    }
}