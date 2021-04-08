using PatternLabs.Lab1.Bridge.Abstractions;
using PatternLabs.Lab1.Bridge.Implementations;

namespace PatternLabs.AbstractFactory
{
    public class SpicyOven : IMultiOven
    {
        public Burrito CookBurrito() => new Burrito(new Chilli());

        public Doner CookDoner() => new Doner(new Chilli());

        public Shawarma CookShawarma() => new Shawarma(new Chilli());
    }
}