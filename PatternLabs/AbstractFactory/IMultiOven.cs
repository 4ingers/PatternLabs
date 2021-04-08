using PatternLabs.Lab1.Bridge.Abstractions;

namespace PatternLabs.AbstractFactory
{
    public interface IMultiOven
    {
        Burrito CookBurrito();

        Doner CookDoner();

        Shawarma CookShawarma();
    }
}