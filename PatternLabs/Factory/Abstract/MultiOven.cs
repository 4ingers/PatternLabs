using PatternLabs.Lab1.Bridge.Abstractions;
using System;
using System.Collections.Generic;

namespace PatternLabs.AbstractFactory
{
    public enum OvenType
    {
        SMOOTH,
        SPICY,
    }

    public abstract class MultiOven
    {
        private static readonly Dictionary<OvenType, MultiOven> instances = new Dictionary<OvenType, MultiOven>();

        protected MultiOven()
        {
        }

        public string Manufacturer { get; set; }

        public static MultiOven GetInstance(OvenType type)
        {
            if (!instances.ContainsKey(type))
            {
                AddInstance(type);
            }
            return instances[type];
        }

        public abstract Burrito CookBurrito();

        public abstract Doner CookDoner();

        public abstract Shawarma CookShawarma();

        public override string ToString()
        {
            return "Manufacturer: " + Manufacturer;
        }

        private static void AddInstance(OvenType type)
        {
            MultiOven oven = type switch
            {
                OvenType.SMOOTH => new SmoothOven(),
                OvenType.SPICY => new SpicyOven(),
                _ => throw new ArgumentException("Invalid oven type"),
            };
            instances.Add(type, oven);
        }
    }
}