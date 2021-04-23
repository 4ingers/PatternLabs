namespace PatternLabs.Eatery.Products
{
    public abstract class Shell
    {
        public abstract string Feature { get; }

        public override string ToString() => Feature;
    }

    public class Pita : Shell
    {
        public override string Feature => "thick pita";
    }

    public class ThinArmenianBread : Shell
    {
        public override string Feature => "thin Armenian bread";
    }
}