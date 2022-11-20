using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace Lab17_2
{
    internal class Program
    {
        static void Show(IEnumerable<int> list)
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static List<int> FillList(List<int> list)
        {            
            var rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(-20, 20));
            }

            return list;
        }
        
        public static void Task()
        {
            List<int> list = new List<int>();
            list = FillList(list);
            Show(list);
            var sum = list.Aggregate((a, b) => a + b);
            Console.WriteLine("The sum is {0}",sum);
            if (sum > 0)
            {
                list = list.Select((x)=>x + 5).ToList();
                int max = list.Max();
                if (! list.All(x => x == 0))
                {
                    list = list.Where((x) => x > 0 && x < max).ToList();
                }
                else
                {
                    var min = list.Min();
                    list = list.Where((x) => x > min+8 && x < max).ToList();
                }
            }
            else
            {
                list = list.Select((x)=>x*(-1)).ToList();
                Show(list);
                var max = list.Max();
                var min = list.Min();
                list = list.Where((x) => x > min+8 && x < max).ToList();
            }
            Show(list);
        }
        public static void Main(string[] args)
        {
            Task();
        }
    }
}