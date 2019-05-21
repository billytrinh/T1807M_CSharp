using System;
using System.Collections.Generic;

namespace Session1
{
    class SessionDemo1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");
            
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x = "+x);

            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("y = "+y);
            
           // SessionDemo2 sd = new SessionDemo2();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i="+i);
            }
            
            List<string> str = new List<string>();
            str.Add("haha");
            str.Add("hehe");
            str.Add("world");
            Console.WriteLine(str[0]);

            foreach (string s in str)
            {
                Console.WriteLine(s);
            }
            
            List<int> ints = new List<int>();
            ints.Add(21);
            ints[0]++;
        }
    }

    class SessionDemo2
    {
        public int age;
        public string name;

        public SessionDemo2(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
    
}
