using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public static class NameGenerator
    {
        public static IEnumerable<string> LinesRead { get; set; } = File.ReadLines("names_generation_list.txt");

        public static Random random = new Random();

        public static string GetGeneratedName()
        {
            return LinesRead.ElementAt(random.Next(0, LinesRead.Count()));
        }
    }
}
