using PatternLabs.Validation.Rules;
using System;

namespace PatternLabs.Validation.Builders
{
    public class RuleBuilder<T>
    {
        public Rule<T> Head { get; private set; }
        public Rule<T> Current { get; private set; }

        public RuleBuilder<T> AddRule(Func<T, object> selector, Predicate<object> predicate)
        {
            var newRule = new Rule<T>(selector, predicate);
            if (Head == null)
            {
                Head = newRule;
                Current = Head;
            }
            else
            {
                Current.Next = newRule;
                Current = Current.Next;
            }
            return this;
        }
    }
}