namespace Interfaces
{
    public class Cookie
    {
        public string Kind { get; set; }
        public int Diameter { get; set; }

        public override string ToString()
        {
            return $"I am a {Kind} cookie with a diameter of {Diameter} centimeter(s)";
        }
    }
}
