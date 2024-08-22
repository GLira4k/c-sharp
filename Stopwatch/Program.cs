using System;

namespace StopWatch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá, Mundo!");
        }

        static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while(currentTime != time)
            {
                currentTime++;
            }
        }
    }


}