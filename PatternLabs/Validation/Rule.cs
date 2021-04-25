using System;

namespace lab4
{
    public class Rule
    {
        private readonly Func<object, object> _selector;
        private readonly Predicate<object> _predicate;

        private Rule _next;

        public Rule(Func<object, object> selector, Predicate<object> predicate)
        {
            _selector = selector;
            _predicate = predicate;
        }

        public void SetNext(Rule rule)
        {
            _next = rule;
        }

        public bool Handle(object obj)
        {
            var selectedField = _selector(obj);
            return _predicate(selectedField);
        }
        
    }
}