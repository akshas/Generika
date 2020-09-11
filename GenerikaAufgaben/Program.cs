using System;

namespace GenerikaAufgaben
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //int x = 1;
            //int y = 2;

            //Aufgabe1<int> a1 = new Aufgabe1<int>();

            //a1.EineGenerischeMethode(ref x, ref y);
            //Console.WriteLine($"x = {x}, y = {y}");

            int[] arr = { 1, 2, 6, 3, 4, 5 };
            string[] arrstirng = { "one", "two", "three", "four", "five" };
            ArrayToList<object> a = new ArrayToList<object>();

            a.Add(ref arr, 6);
            a.Add(ref arr, 7);
            a.Remove(ref arr, 6);
            a.Remove(ref arrstirng, "one");
            a.Remove(ref arrstirng, "three");

            foreach (var element in arrstirng)
            {
                Console.WriteLine(element);
            }

        }
    }
}
