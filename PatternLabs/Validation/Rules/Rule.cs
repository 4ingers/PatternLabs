using System;

namespace PatternLabs.Validation.Rules
{
    public class Rule<T>
    {
        private readonly Func<T, object> selector;
        private readonly Predicate<object> predicate;

        public Rule(Func<T, object> selector, Predicate<object> predicate)
        {
            this.selector = selector;
            this.predicate = predicate;
        }

        public Rule<T> Next { get; set; }

        public bool Handle(T obj)
        {
            if (!predicate(selector(obj)))
            {
                throw new OperationCanceledException();
            }
            if (Next == null)
            {
                return true;
            }
            return Next.Handle(obj);
        }
    }
}