using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejka_i_Stos
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> litery = new Queue<string>();
            Stack<string> cyfry = new Stack<string>();

            cyfry.Push("1");
            cyfry.Push("2");
            cyfry.Push("3");
            cyfry.Push("4");

            litery.Enqueue("a");
            litery.Enqueue("b");
            litery.Enqueue("c");
            litery.Enqueue("d");

            foreach(string cyfra in cyfry)
            {
                Console.WriteLine(cyfra);
            }

            foreach (string litera in litery)
            {
                Console.WriteLine(litera);
            }

            litery.Enqueue(cyfry.Pop());
            litery.Enqueue(cyfry.Pop());

            foreach (string litera in litery)
            {
                Console.WriteLine(litera);
            }

            Console.WriteLine(litery.Peek());
            Console.WriteLine(cyfry.Peek());

            cyfry.Pop();
            cyfry.Pop();

            litery.Enqueue("e");

            foreach (string cyfra in cyfry)
            {
                Console.WriteLine(cyfra);
            }

            foreach (string litera in litery)
            {
                Console.WriteLine(litera);
            }

            litery.Enqueue(cyfry.Pop());
            foreach (string litera in litery)
            {
                Console.WriteLine(litera);
            }

        }
    }
}
