using PatternLabs.Lab1.Bridge.Abstractions;
using PatternLabs.Lab1.Bridge.Implementations;

namespace PatternLabs.AbstractFactory
{
    public class SmoothOven : MultiOven
    {
        public override Burrito CookBurrito() => new Burrito(new Cheese());

        public override Doner CookDoner() => new Doner(new Cheese());

        public override Shawarma CookShawarma() => new Shawarma(new Cheese());
    }
}