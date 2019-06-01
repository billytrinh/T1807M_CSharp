using System.Threading;
using System;
namespace Session1
{
    public class ThreadDemo
    {
        public static void Main(string[] args)
        {
            Thread newThread = new Thread(delegate
            (Object msg)
            {
                String ms = (String) msg;
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(ms);
                    Thread.Sleep(100);
                }
                
            });
            // Kích hoạt chạy newThread.
            newThread.Start("haha");
 
            Console.WriteLine("Call Write('-') in main Thread...\n");
 
            // Trong Thread chính ghi ra các ký tự '-'
            for (int i = 0; i < 50; i++)
            {
                Console.Write('-');
 
                // Ngủ (sleep) 70 mili giây.
                Thread.Sleep(70);
            }
 
 
            Console.WriteLine("Main Thread finished!\n");
            Console.Read();
        }

        public static void running()
        {
            // Vòng lặp 100 lần ghi ra ký tự 'B'
            for (int i = 0; i < 100; i++)
            {
                Console.Write('B');
 
                // Ngủ 100 mili giây
                Thread.Sleep(70);
            }
        }
    }
}