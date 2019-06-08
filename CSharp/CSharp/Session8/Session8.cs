using System;
using System.Threading;

namespace Session1.Session8
{
    public class Number
    {
        public int x = 0;
        public int y = 0;

        public void changeValue()
        {
            x++;
            y++;
        }

        public void showValue()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
    
    public class Session8
    {
        public static Number number = new Number();
        public static void Main(string[] args)
        {
            Student s = new Student();
           // s.mark[0] = 4;
           s[0] = 3;
           Console.WriteLine(s[0]);
           
            Thread t1 = new Thread(RunThread);
            Thread t2 = new Thread(RunThread);
            t1.Start();
            //t1.Join();
            t1.IsBackground = true;
            
            t2.Start();
        }

        public static void RunThread()
        {
            for (int i = 0; i < 100; i++)
            {
                lock (number)
                {
                    number.changeValue();
                    number.showValue();
                }
               
            }
        }
    }
}