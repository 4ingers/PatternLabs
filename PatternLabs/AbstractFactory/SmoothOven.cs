using PatternLabs.Lab1.Bridge.Abstractions;
using PatternLabs.Lab1.Bridge.Implementations;

namespace PatternLabs.AbstractFactory
{
    public class SmoothOven : IMultiOven
    {
        public Burrito CookBurrito() => new Burrito(new Cheese());

        public Doner CookDoner() => new Doner(new Cheese());

        public Shawarma CookShawarma() => new Shawarma(new Cheese());
    }
}