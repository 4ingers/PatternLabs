using PatternLabs.Lab1.Bridge.Implementations;

namespace PatternLabs.Lab1.Bridge.Abstractions
{
    public class Doner : SuperSandwich
    {
        public Doner(IExtra extra) : base(extra)
        {
        }

        public override string Nation => "german";
    }
}