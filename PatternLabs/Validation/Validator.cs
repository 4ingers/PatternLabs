using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4
{
    public class Validator : IRuleBuilder
    {
        private readonly List<Rule> _rules = new List<Rule>();

        public void AddRule(Func<object, object> selector, Predicate<object> predicate)
        {
            var rule = new Rule(selector, predicate);
            _rules.Add(rule);
        }

        public void Validate(object obj)
        {
            if (_rules.Any(rule => !rule.Handle(obj)))
            {
                throw new OperationCanceledException("Validation failed");
            }
        }
        
    }
}