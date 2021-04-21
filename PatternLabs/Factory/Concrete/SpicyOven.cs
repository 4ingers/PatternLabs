using PatternLabs.Lab1.Bridge.Abstractions;
using PatternLabs.Lab1.Bridge.Implementations;

namespace PatternLabs.AbstractFactory
{
    public class SpicyOven : MultiOven
    {
        public override Burrito CookBurrito() => new Burrito(new Chilli());

        public override Doner CookDoner() => new Doner(new Chilli());

        public override Shawarma CookShawarma() => new Shawarma(new Chilli());
    }
}