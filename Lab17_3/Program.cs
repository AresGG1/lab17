using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Lab17_3
{
    internal class Program
    {
        public static List<Timetable> FillList(List<Timetable> list)
        {
            Timetable tt1 = new Timetable(){nazv = "name1", date = "12.12.2022", numr = 11,time = "18:00", capacity = 40};
            Timetable tt2 = new Timetable(){nazv = "name2", date = "12.02.2022", numr = 1,time = "12:00", capacity = 140};
            Timetable tt3 = new Timetable(){nazv = "name3", date = "5.12.2022", numr = 17,time = "13:20", capacity = 240};
            Timetable tt4 = new Timetable(){nazv = "name4", date = "25.6.2021", numr = 21,time = "16:15", capacity = 80};
            list.Add(tt1);
            list.Add(tt2);
            list.Add(tt3);
            list.Add(tt4);
            return list;
        }

        public static void Task(List<Timetable> list)
        {
            double avgPlaces = list.Select((x) => x.capacity).ToList().Average();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(avgPlaces);
            list = list.Where((x)=>x.capacity > avgPlaces).ToList();
            list = list.OrderByDescending((x)=>x.numr).ToList();
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var elem in list)
            {
                Console.WriteLine(elem);
            }
        }
        
        public static void Main(string[] args)
        {
            Task(FillList(new List<Timetable>()));
        }
    }
}