using Session3;

namespace Session3
{
    public class Session3Demo1
    {
        
    }

    public class Session3Demo2
    {
        
    }

    namespace MyNamespace
    {
        public class MyDemo
        {
            
        }
    }

}

namespace Session4
{
    public class Session4Demo1
    {
        public static void Main(string[] args)
        {
            Session3Demo1 s1 = new Session3Demo1();
            
            Session3.Session3Demo2 s2 = new Session3.Session3Demo2();
            Session3.MyNamespace.MyDemo m1 = new Session3.MyNamespace.MyDemo();
        }
    }
}