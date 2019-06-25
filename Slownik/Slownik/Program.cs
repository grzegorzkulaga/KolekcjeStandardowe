using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slownik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Zwierzeta = new Dictionary<string, string>();

            Zwierzeta.Add("kot", "4");
            Zwierzeta.Add("pies", "4");
            Zwierzeta.Add("krowa", "4");
            Zwierzeta.Add("wąż", "0");
            Zwierzeta.Add("lis", "4");

            foreach(KeyValuePair<string, string> animals in Zwierzeta)
            {
                Console.WriteLine(animals.Key, animals.Value);
            }

            if(Zwierzeta.ContainsKey("pies"))
            {
                string value = Zwierzeta["pies"];
                Console.WriteLine(value);
            }

            string test;
            if(Zwierzeta.TryGetValue("pies", out test))
            {
                Console.WriteLine(test);
            }

            if (Zwierzeta.ContainsKey("6"))
            {
                string value = Zwierzeta["6"];
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Nie ma zwierząt z 6 nogami");
            }

            Zwierzeta.Add("pająk", "6");
            foreach (KeyValuePair<string, string> animals in Zwierzeta)
            {
                Console.WriteLine("Zwierze: " + animals.Key + ", liczba nóg: " + animals.Value);
            }

            foreach (KeyValuePair<string, string> animals in Zwierzeta)
            {
                if (animals.Value == "4")
                    Console.WriteLine("Zwierze: " + animals.Key + ", liczba nóg: " + animals.Value);
            }

            int suma = 0;
            foreach(KeyValuePair<string, string> animals in Zwierzeta)
            {
                suma += Convert.ToInt32(animals.Value);
            }
            Console.WriteLine("Suma nóg: " + suma);

            Zwierzeta.Remove("pająk");

            foreach (KeyValuePair<string, string> animals in Zwierzeta)
            {
                Console.WriteLine("Zwierze: " + animals.Key + ", liczba nóg: " + animals.Value);
            }
        }
    }
}
