
using System;
using System.Threading;
using System.Threading.Tasks;

namespace lockdemo
{
    class Program
    {    
        private static object _locker = new object();
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            {
                new Thread(Work).Start();
            }
        }
        public static void Work()
        {
            lock (_locker)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is starting...");
                Thread.Sleep(2000);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is completed.");
            }
        }
    }
}

