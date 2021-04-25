using System;

namespace lab4
{
    public interface IRuleBuilder
    {
        void AddRule(Func<object, object> selector, Predicate<object> predicate);
    }
}