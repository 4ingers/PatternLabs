using System;
using PatternLabs.Lab1.Bridge.Abstractions;

namespace PatternLabs.AbstractFactory
{
    public abstract class MultiOven
    {
        protected MultiOven() { }

        private static MultiOven instance = null;

        public static MultiOven Instance => instance ??= CreateInstance();

        private static MultiOven CreateInstance()
        {
            return Program.env switch
            {
                "smooth" => new SmoothOven(),
                "spicy" => new SpicyOven(),
                _ => throw new ArgumentException("Invalid argument"),
            };
        }

        public abstract Burrito CookBurrito();

        public abstract Doner CookDoner();

        public abstract Shawarma CookShawarma();
    }
}