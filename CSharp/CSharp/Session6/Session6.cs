using System;

namespace Session1.Session6
{
    public delegate void showAnything<T>(T n);
    public class Session6
    {
        public static void Main(string[] args)
        {
            showAnything<string> am = delegate(string s) { 
                Console.WriteLine("hello "+s);
            };
            am("trump");
            
            //MyGeneric<string> m1 = new MyGeneric<string>();
            //MyGeneric<int> m2 = new MyGeneric<int>();

           // m1.attribute_1 = "hahaha";

            //m2.attribute_1 = 2;
            
            MyGeneric<Human> m1 = new MyGeneric<Human>();
            MyGeneric<Asian> m2 = new MyGeneric<Asian>();
            m1.sayAnything(new Asian());
            m1.sayAnything(new Human());
           // m1.sayAnything(3.14);
           
           showAnything<int> sn = new showAnything<int>(changeNum);
           showAnything<string> sn2 = new showAnything<string>(showString);
           //sn += sn2;--> error
           sn(3);
           sn2("aaaa");
        }

        public static void changeNum(int n)
        {
            Console.WriteLine(n*n);
        }

        public static void showString(string mg)
        {
            Console.WriteLine(mg);
        }
    }
}