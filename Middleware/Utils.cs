namespace Middleware
{
    public class Utils
    {
        public static bool IsLucky()
        {
            var random = new Random();
            int randomNum = random.Next(0, 11);
            return randomNum >= 5;
        }
    }
}
