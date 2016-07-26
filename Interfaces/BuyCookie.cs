using System;

namespace Interfaces
{
    public class BuyCookie : ICookie
    {
        public Cookie GetCookie()
        {
            Console.WriteLine("\n\tGoing to the store to buy cookies");
            
            // go to the store, buy cookies
            return new Cookie
            {
                Diameter = 7, Kind = "Oatmeal Rasin"
            };
        }
    }
}
