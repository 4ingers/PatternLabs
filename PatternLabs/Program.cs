using PatternLabs.AbstractFactory;
using PatternLabs.Lab1.Bridge.Abstractions;
using PatternLabs.Lab1.Bridge.Implementations;
using System;

namespace PatternLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            IMultiOven smoothOven = new SmoothOven();
            IMultiOven spicyOven = new SpicyOven();

            SuperSandwich[] superSandwiches = new SuperSandwich[]
            {
                smoothOven.CookBurrito(),
                spicyOven.CookBurrito(),
                smoothOven.CookDoner(),
                spicyOven.CookDoner(),
                smoothOven.CookShawarma(),
                spicyOven.CookShawarma(),
            };

            foreach (SuperSandwich superSandwich in superSandwiches)
            {
                Console.WriteLine(superSandwich.Description());
            }
        }
    }
}
