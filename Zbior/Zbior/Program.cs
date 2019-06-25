using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbior
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(1);
            A.Add(3);
            A.Add(5);
            A.Add(2);
            A.Add(7);
            A.Add(8);

            B.Add(2);
            B.Add(1);
            B.Add(5);
            B.Add(3);
            B.Add(9);
            B.Add(6);

            foreach(int cyfra in A)
            {
                Console.WriteLine(cyfra);
            }

            foreach (int cyfra in B)
            {
                Console.WriteLine(cyfra);
            }

            DisplaySet(A);
            DisplaySet(B);

            HashSet<int> C = new HashSet<int>();
            C.UnionWith(A);
            C.UnionWith(B);

            int[] tab = C.ToArray();
            Array.Sort(tab);
            Array.Reverse(tab);

            C.Clear();
            C.UnionWith(tab);
            foreach(int cyfra in C)
            {
                Console.WriteLine(cyfra);
            }

            int suma = 0, srednia = 0;
            foreach(int cyfra in C)
            {
                suma = suma + cyfra;
            }
            srednia = suma / C.Count;
            Console.WriteLine("Średnia:"+srednia);

            A.IntersectWith(B);
            foreach(int cyfra in A)
            {
                Console.WriteLine(cyfra);
            }
        }

        private static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
    }
}
