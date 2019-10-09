using System;

namespace Tuples
{
    class Program
    {
        private static Random rnd;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static object[] GetStuff1() 
        {
            // Create array of type objects with 3 "houses"
            object[] objs = new object[3];
            objs[0] = rnd.Next();
            objs[1] = rnd.NextDouble(); // Retorna um valor entre 0 e 1;
            objs[2] = rnd.NextDouble() < 0.5;

            return objs;
        }

        static void Main(string[] args)
        {
            rnd = new Random();

            object[] objs = GetStuff1();
            foreach (object o in objs) 
            {
                Console.WriteLine(o);
            }
        }
    }
}
