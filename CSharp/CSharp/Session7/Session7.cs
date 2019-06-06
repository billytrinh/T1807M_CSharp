using System;
using System.Threading;

namespace Session1.Session7
{
    //public delegate void RunAnything();
    public class Session7
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(RunSubThread);
            t1.Start("hello");
            
            Thread t2 = new Thread(new Session7().Run2);
            t2.Start(20);
            
            Thread t3 = new Thread(delegate()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Ham an danh "+i);
                    Thread.Sleep(100);
                }
            });
            
            t3.Start();
            
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main Thread "+i);
                Thread.Sleep(100);
            }

           
        }

        public static void RunSubThread(Object msg)
        {
            string m = (string) msg;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Sub thread --"+m+"-- "+i);
                Thread.Sleep(100);
            }
        }

        public void Run2(Object x)
        {
            int n = (int) x;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sub 2 thread "+i);
                Thread.Sleep(100);
            }
        }
    }
}