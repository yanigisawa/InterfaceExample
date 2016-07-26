using Interfaces;
using System;

namespace BakeCookie
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICookie cookieInterface = new BakeCookie();
            Console.WriteLine(cookieInterface.GetCookie());

            cookieInterface = new BuyCookie();
            Console.WriteLine(cookieInterface.GetCookie());

            Console.ReadLine();
        }
    }
}
