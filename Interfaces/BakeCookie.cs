using Interfaces;
using System;

namespace BakeCookie
{
    public class BakeCookie : ICookie
    {
        public Cookie GetCookie()
        {
            Console.WriteLine("\n\tBaking the cookie.");
            // baking begins

            return new Cookie
            {
                Diameter = 10, Kind = "Chocolate Chip"
            };
        }
    }
}
