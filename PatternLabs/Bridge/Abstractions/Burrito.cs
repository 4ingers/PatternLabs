using PatternLabs.Lab1.Bridge.Implementations;

namespace PatternLabs.Lab1.Bridge.Abstractions
{
    public class Burrito : SuperSandwich
    {
        public Burrito(IExtra extra) : base(extra)
        {
        }

        public override string Nation => "spanish";
    }
}