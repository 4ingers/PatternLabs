using PatternLabs.Lab1.Bridge.Implementations;

namespace PatternLabs.Lab1.Bridge.Abstractions
{
    abstract public class SuperSandwich
    {
        protected IExtra extra;

        public SuperSandwich(IExtra extra)
        {
            this.extra = extra;
        }

        public abstract string Nation { get; }

        public string Description()
        {
            string superSandwich = GetType().Name.ToLower();
            string special = extra.GetType().Name.ToLower();
            return $"It's {Nation} {extra.Special}... " +
                $"Sounds like a [{superSandwich}] with [{special}]!";
        }
    }
}