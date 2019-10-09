using System;

namespace Tuples
{
    class Program
    {
        private static Random rnd;

        /*
        /// <summary>
        /// Get Stuff using class object
        /// </summary>
        /// <returns> Return object in specific place with rnd</returns>
        private static object[] GetStuff1() 
        {
            // Create array of type objects with 3 "houses"
            object[] objs = new object[3];
            objs[0] = rnd.Next();
            objs[1] = rnd.NextDouble(); // Retorna um valor entre 0 e 1;
            objs[2] = rnd.NextDouble() < 0.5;

            return objs;
        }*/


        /*
        /// <summary>
        /// Get Stuff using return with rnd
        /// </summary>
        /// <returns> return random numbs of values</returns>
        private static Stuff GetStuff() 
        {
            return new Stuff(rnd.Next(), rnd.NextDouble(), rnd.NextDouble() < 0.5);
        }*/


        /*
        /// <summary>
        /// Method to return random numbers with keyword out
        /// </summary>
        /// <param name="a"> Receive int</param>
        /// <param name="b"> Receive double</param>
        /// <param name="c"> Receive bool</param>
        private static void GetStuff(out int a, out double b, out bool c) 
        {
            a = rnd.Next();
            b = rnd.NextDouble();
            c = rnd.NextDouble() < 0.5;
        }*/

        /// <summary>
        /// Get Stuff with tuples with specific types
        /// </summary>
        /// <returns> return tuples</returns>
        private static Tuple<int, double, bool> GetStuff() 
        {
            Tuple<int, double, bool> stuff = new Tuple<int, double, bool>
                (rnd.Next(), rnd.NextDouble(), rnd.NextDouble() < 0.5);
            return stuff;
        }


        static void Main(string[] args)
        {
            // Instance of random rnd
            rnd = new Random();

            // Get tuple method of function
            Tuple<int, double, bool> t = GetStuff();

            // Print out Items of tuple
            Console.WriteLine("In= "+ t.Item1 + " do= "+ t.Item2 + " Bo= "+ t.Item3);
        }
    }
}
