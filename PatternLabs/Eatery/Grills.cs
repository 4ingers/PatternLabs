using System;
using System.Collections.Generic;
using PatternLabs.Eatery.Products;

namespace PatternLabs.Eatery
{
    public enum GrillType
    {
        BURRITO,
        DONER,
        SHAWARMA,
    }

    public abstract class Grill
    {
        private static readonly Dictionary<GrillType, Grill> instances = new Dictionary<GrillType, Grill>();

        protected Grill()
        {
        }

        public static Grill GetInstance(GrillType type)
        {
            if (!instances.ContainsKey(type)) AddInstance(type);
            return instances[type];
        }

        public abstract Morsel CookThick();

        public abstract Morsel CookThin();

        private static void AddInstance(GrillType type)
        {
            Grill instance = type switch
            {
                GrillType.BURRITO => new BurritoGrill(),
                GrillType.DONER => new DonerGrill(),
                GrillType.SHAWARMA => new ShawarmaGrill(),
                _ => throw new ArgumentException("Invalid grill type"),
            };
            instances.Add(type, instance);
        }
    }

    public class BurritoGrill : Grill
    {
        public override Morsel CookThick() => new Burrito(new Pita());

        public override Morsel CookThin() => new Burrito(new ThinArmenianBread());
    }

    public class DonerGrill : Grill
    {
        public override Morsel CookThick() => new Doner(new Pita());

        public override Morsel CookThin() => new Doner(new ThinArmenianBread());
    }

    public class ShawarmaGrill : Grill
    {
        public override Morsel CookThick() => new Shawarma(new Pita());

        public override Morsel CookThin() => new Shawarma(new ThinArmenianBread());
    }
}