using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharacterInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.Count("Hello").ToList().ForEach(x => Console.WriteLine($"{x.Key} : {x.Value}"));

            Console.ReadLine();
        }
    }
    public class Kata
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c] += 1;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }
            return dic;

        }
    }
}
