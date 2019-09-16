using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            //int sum = 0;
            for (int i = 1; i < intArray.Length; i++)
            {
                intArray[i] += intArray[i - 1];
            }
            //reach(var item in intArray){
            //    sum += item;
            //    Console.WriteLine(sum);

            //}
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }

        //public static List<string> Testifsite(string url)
        //{
        //    const string pattern = @"http://(www\.)?([^\.]+)\.com";
        //    List<string> result = new List<string>();
        //    MatchCollection myMatches = Regex.Matches(url, pattern);
        //    foreach (Match currentmatch in myMatches)
        //        result.Add(currentmatch.Value);
        //         return result;
        //}
    }
}
