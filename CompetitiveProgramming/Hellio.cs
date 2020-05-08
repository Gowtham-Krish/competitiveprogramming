//using System;
//using System.Collections.Generic;

//namespace Kattis
//{
//    public class program
//    {
//        private const int EarthOrbitDays = 365;
//        private const int MarsOrbitDays = 687;
//        public static void Main(string[] args)
//        {
//            var inputList = new List<string>();
//            string input;
//            while (true)
//            {
//                input = Console.ReadLine();
//                if (string.IsNullOrWhiteSpace(input))
//                {
//                    break;
//                }
//                inputList.Add(input);
//            }

//            for (int i = 0; i < inputList.Count; i++)
//            {
//                var daysToMeetAtZero = 0;
//                var split = inputList[i].Split(" ");
//                int earthDays = Convert.ToInt32(split[0]);
//                int marsDays = Convert.ToInt32(split[1]);

//                if (earthDays != 0)
//                {
//                    daysToMeetAtZero = 365 - earthDays;
//                    marsDays = (marsDays + daysToMeetAtZero) % MarsOrbitDays;
//                }
//                while (marsDays != 0)
//                {
//                    daysToMeetAtZero += EarthOrbitDays;
//                    marsDays = (marsDays + EarthOrbitDays) % MarsOrbitDays;
//                }

//                Console.WriteLine($"Case {i + 1}: {daysToMeetAtZero}");
//            }
//        }
//    }
//}