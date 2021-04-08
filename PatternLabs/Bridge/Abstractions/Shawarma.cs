using PatternLabs.Lab1.Bridge.Implementations;

namespace PatternLabs.Lab1.Bridge.Abstractions
{
    public class Shawarma : SuperSandwich
    {
        public Shawarma(IExtra extra) : base(extra)
        {
        }

        public override string Nation => "russian";
    }
}