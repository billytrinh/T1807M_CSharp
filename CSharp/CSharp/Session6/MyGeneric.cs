namespace Session1.Session6
{
    public class MyGeneric <E> 
        where E : Human
    {
        public E attribute_1;
        public E attribute_2;
        
        public void sayAnything <T> (T msg)
            where T : Human
        {
    
        }
    }
    
    
}