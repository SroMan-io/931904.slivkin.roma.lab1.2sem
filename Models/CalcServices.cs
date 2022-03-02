namespace WebApplication1.Models
{

    public class CalcServices
    {
        public Random rand = new Random();

        public int x, y, add, sub, mult, div;
        
        public CalcServices() { x = rand.Next(0, 11); y = rand.Next(0, 11); add = x + y; sub = x - y; mult = x * y;
            if (y == 0)  div = 100;
            else div = x / y; }        
    }
}
