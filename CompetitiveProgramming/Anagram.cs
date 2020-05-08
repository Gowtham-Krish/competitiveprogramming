//using system;
//using system.collections.generic;
//using system.linq;
//using system.numerics;

//namespace kattis
//{
//    public class program
//    {
//        public static void main(string[] args)
//        {
//            while (true)
//            {
//                var input = console.readline();
//                var countofcharacters = new dictionary<char, int>();
//                if (string.isnullorwhitespace(input))
//                {
//                    break;
//                }
//                foreach (var c in input)
//                {
//                    if (!countofcharacters.trygetvalue(c, out int value))
//                    {
//                        var count = input.count(x => x == c);
//                        countofcharacters.add(c, count);
//                    }
//                }
//                var totalfact = factorial(input.length);
//                biginteger uniquecount = 1;
//                if (countofcharacters.any(x => x.value > 1))
//                {
//                    foreach (var pair in countofcharacters)
//                    {
//                        uniquecount *= factorial(pair.value);
//                    }
//                }

//                console.writeline(totalfact / uniquecount);
//            }
//        }

//        private static biginteger factorial(int num)
//        {
//            if (num == 0 || num == 1)
//            {
//                return 1;
//            }
//            return num * factorial(num - 1);
//        }
//    }
//}