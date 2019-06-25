using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gatunki = new List<string>();

            gatunki.Add("kot");
            gatunki.Add("pies");
            gatunki.Add("słoń");
            gatunki.Add("nosorożeć");
            gatunki.Add("zebra");

            foreach(string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }

            //gatunki.RemoveAt(0);
            gatunki.Remove("zebra");
            gatunki.Remove("kot");
            foreach (string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }

            gatunki.Insert(3, "mucha");
            gatunki.Insert(1, "gazela");
            foreach (string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }

            gatunki.Remove("gazela");
            foreach (string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }
            Console.WriteLine(gatunki.IndexOf("mucha"));

            gatunki.Reverse();
            foreach (string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }

            gatunki.Sort();
            foreach (string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }

            if (gatunki.Contains("krowa", StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
