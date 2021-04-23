using PatternLabs.Eatery.Staff;

namespace PatternLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Chief chief = new Chief();
            Cooker cooker = new Cooker();
            chief.CookThickDoner(cooker).Tell();
        }
    }
}
