
using System;
using System.Threading;
using System.Threading.Tasks;

namespace lockdemo
{
    class Program
    {
        static AutoResetEvent _auto = new AutoResetEvent(true);

        static void Main(string[] args)
        {
           
            for (int i = 0; i <= 5; i++)
            {
                new Thread(Write).Start();
            }
            //Thread.Sleep(2000);
            //_auto.Set();

            Console.ReadKey();
        }
        public static void Write()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is waiting...");
            _auto.WaitOne();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is writing ...");
            Thread.Sleep(2000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is writing completed");
            _auto.Set();

        }
       




    }
}

