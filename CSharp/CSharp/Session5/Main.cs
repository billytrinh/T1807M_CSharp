using System;

namespace Session5
{
    public delegate void showString(string s);
    
    public class Session5
    {
        public event showString ShowMessage;

        public void running()
        {
            Console.WriteLine("Running...");
            if (ShowMessage != null)
            {
                ShowMessage("Chuc suc khoe.");
            }
        }
        public static void Main(string[] args)
        {
            showString ss = new showString(SayHello);
            showString s2 = new showString(SayBye);
            showString s3 = new showString(new Session5().SayAgain);
            //ss += s2;
            //ss += s3;
            ss += s2 += s3;
            ss("Quang Hoa");
            Session5 session5 = new Session5();
            session5.ShowMessage += SayHello;
            session5.ShowMessage += SayBye;
            
            session5.running();
        }

        public static void SayHello(string s)
        {
            Console.WriteLine("Hello "+ s);
        }

        public static void SayBye(string s)
        {
            Console.WriteLine("Bye bye "+ s);
        }

        public void SayAgain(string s)
        {
            Console.WriteLine("See u again "+ s);
        }
    }
}