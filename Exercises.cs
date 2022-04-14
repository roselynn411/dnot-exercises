using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        //public static string ReverseStringHard(string quote)
        //{
        //    throw new NotImplementedException();
        //}

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            return $"Hello {name}!";
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string fullName)
        {
            string[] nameSplit = fullName.Split(' ');

            return nameSplit[0];
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string s)
        {
            string reversestring = "";
            int length;

            length = s.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + s[length];
                length--;
            }
            return reversestring;
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        public static string PrintTimesTable(int num)
        {

            string result = "";
            for (int i = 1; i < 10; i++)
            {
                result += $"{num} * {i} = {num * i}\r\n";
            }
            result += $"{num} * {10} = {num * 10}";
            return result;
        }
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double num)
        {
            string result = ((num - 273.15) * 9 / 5 + 32).ToString("N2");
            return Convert.ToDouble(result);
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            double result = (sum / arr.Length);
            //Console.WriteLine(sum/arr.Length);
            //Console.WriteLine(sum);
            //Console.WriteLine(result);
            return result;
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] arr)
        {
            double average = arr.Average();
            return average;
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        public static string DrawTriangle(int num, int width)
        {
            string result = "";
            int widthCount = width;
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < widthCount; i++)
                {
                    result += num;
                }
                widthCount -= 1;
                if (widthCount != 0)
                {
                    result += "\r\n";
                }
            }
            return result;
        }

        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */


        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds)
        {
            double d = Convert.ToDouble(distance);
            double h = Convert.ToDouble(hours * 60 * 60);
            double m = Convert.ToDouble(minutes * 60);
            double s = Convert.ToDouble(seconds);
            double result = Math.Round(distance / ((h + m + s) / 60 / 60));
            //Console.WriteLine(h);
            //Console.WriteLine(m);
            //Console.WriteLine(s);
            //Console.WriteLine(result);
            return $"{result}MPH";
        }
        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char character)
        {
            bool result = false;
            switch (character)
            {
                case 'a':
                    result = true;
                    break;
                case 'e':
                    result = true;
                    break;
                case 'i':
                    result = true;
                    break;
                case 'o':
                    result = true;
                    break;
                case 'u':
                    result = true;
                    break;
                default:
                    break;
            }
            return result;
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char character)
        {
            bool result = true;
            switch (character)
            {
                case 'a':
                    result = false;
                    break;
                case 'e':
                    result = false;
                    break;
                case 'i':
                    result = false;
                    break;
                case 'o':
                    result = false;
                    break;
                case 'u':
                    result = false;
                    break;
                default:
                    break;
            }
            return result;
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937.
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int num)
        {
            int count = 0;
            int number = num;
            while (number != 1)
            {
                if (number % 2 != 0)
                {
                    number *= 3;
                    number += 1;
                    count++;
                }
                if (number % 2 == 0)
                {
                    number /= 2;
                    count++;
                }
            }
            return count;
        }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime date)
        {
            DateTime dt = date;
            string dateString = dt.ToString().Split(' ')[0];
            string[] d = dateString.Split('/');
            int day = int.Parse(d[1]);
            int month = int.Parse(d[0]);
            int year = int.Parse(d[2]);
            //Console.WriteLine(String.Join(Environment.NewLine, d));
            //Console.WriteLine($"year: {year}");
            return new DateTime[] { new DateTime(year, month, day), new DateTime(year, month, day + 1), new DateTime(year, month, day + 2), new DateTime(year, month, day + 3), new DateTime(year, month, day + 4), new DateTime(year, month, day + 5), new DateTime(year, month, day + 6) };
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(int date)
        {
            //TODO Test is written with int not date time object.
            //Console.WriteLine($"date: {date % 4}");
            if (date % 4 == 0)
            {
                if (date % 100 != 0)
                {
                    return true;
                }
                if (date % 100 == 0 && date % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static double MortgageCalculator(decimal loanbalance, double interestrate, int loanterm, int paymentperiod)
        {
            double rate = interestrate / 100 / 12;
            double loan = Convert.ToDouble(loanbalance);
            double term = Convert.ToDouble(loanterm * 12);
            double bimonthlymultiplyer = Convert.ToDouble(12 / paymentperiod);

            double periodPayment = loan * (rate * Math.Pow((1 + rate), term) / (Math.Pow((1 + rate), term) - 1));

            return Math.Round(periodPayment, 2) * bimonthlymultiplyer;
        }
        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        public static string DuckGoose(int num)
        {
            string result = "";
            for (int i = 1; i <= num; i++)
            {
                if (i == num)
                {

                    if (i % 3 == 0 && i % 5 != 0)
                    {
                        result += "Duck";
                    }
                    if (i % 5 == 0 && i % 3 != 0)
                    {
                        result += "Goose";
                    }
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        result += "DuckGoose";
                    }
                    if (i % 5 != 0 && i % 3 != 0)
                    {
                        result += i;
                    }

                }
                if (i != num)
                {

                    if (i % 3 == 0 && i % 5 != 0)
                    {
                        result += "Duck\r\n";
                        //result += "Duck" + Environment.NewLine; Did the same thing but threw test error.
                    }
                    if (i % 5 == 0 && i % 3 != 0)
                    {
                        result += "Goose\r\n";
                    }
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        result += "DuckGoose\r\n";
                    }
                    if (i % 5 != 0 && i % 3 != 0)
                    {
                        result += $"{i}\r\n";
                    }
                }
            }
            Console.WriteLine(result);
            return result;
        }
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}