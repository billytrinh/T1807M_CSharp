namespace Session1.Session8
{
    public class Student
    {
        
        public int[] mark = new int[5];

        public int this[int index]
        {
            get
            {
                return mark[index];
            }
            set
            {
                mark[index] = value;
            }
        }
    }
}