//using System;
//using System.Collections.Generic;

//namespace Kattis
//{
//    public class Program
//    {
//        private static double AnglePerPixel = 0.0;
//        public static void Main(string[] args)
//        {
//            var input = Console.ReadLine();
//            var split = input.Split(" ");
//            int totalPixels = Convert.ToInt32(split[0]);
//            float viewingAngle = Convert.ToSingle(split[1]);
//            AnglePerPixel = viewingAngle / totalPixels;
//            var finalPicture = new List<string>();
//            while (true)
//            {
//                var pictureInput = Console.ReadLine();
//                if (string.IsNullOrWhiteSpace(pictureInput))
//                {
//                    break; //Break if the input is empty.
//                }
//                finalPicture.Add(pictureInput);
//            }

//            foreach (var pixel in finalPicture)
//            {
//                var splitPixel = pixel.Split(" ");
//                var red = Convert.ToDouble(splitPixel[0]);
//                var green = Convert.ToDouble(splitPixel[1]);
//                var blue = Convert.ToDouble(splitPixel[2]);
//                double angleOfBlue = 0.0f;
//                double angleOfRed = 0.0f;
//                double angleOfGreen = 0.0f;
//                if (red != 0)
//                {
//                    angleOfRed = red * AnglePerPixel;
//                }
//                if (green != 0)
//                {
//                    angleOfGreen = green * AnglePerPixel;
//                }
//                if (blue != 0)
//                {
//                    angleOfBlue = blue * AnglePerPixel;
//                }

//            }
//        }
//    }
//}