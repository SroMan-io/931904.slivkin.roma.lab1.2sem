namespace WebApplication1.Services
{

    public static class ServiceProviderExtensions
    {
        public static void AddCalcService(this IServiceCollection services)
        {
            services.AddTransient<CalcService>();
        }
    }
    public class CalcService
    {
        
            public Random rand = new Random();

            public int x, y, add, sub, mult, div;

            public CalcService()
            {
                x = rand.Next(0, 11); y = rand.Next(0, 11); add = x + y; sub = x - y; mult = x * y;
                if (y == 0) div = 100;
                else div = x / y;
            }
        }
    
}
