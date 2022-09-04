using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CLean
{
    internal class NameProvider
    {
        public string getName()
        {
            Console.WriteLine("Enter your name");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            return string.IsNullOrEmpty(name) ? "" : name;
        }
    }
}
