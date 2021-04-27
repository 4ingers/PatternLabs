using PatternLabs.Eatery.Staff;
using PatternLabs.Sortings;
using PatternLabs.Sortings.Strategies;
using PatternLabs.Validation.Builders;
using PatternLabs.Validation.ExampleClasses;
using PatternLabs.Validation.Rules;
using System;

namespace PatternLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab3();
        }

        static void Lab1()
        {
            Chief chief = new Chief();
            Cooker cooker = new Cooker();
            chief.CookThickDoner(cooker).Tell();
        }

        static void Lab3()
        {
            Func<int, int, int> comparer = (x, y) => x.CompareTo(y);
            Collection<int> collection1 = new Collection<int>
            {
                6, 4, 7, 8, 5, 7, 3
            };
            collection1.Comparer = comparer;
            collection1.Print();
            Collection<int> collection2 = (Collection<int>)collection1.Clone();
            collection2.Comparer = comparer;
            collection2.SortingStrategy = new QuickSort<int>();
            collection2.Sort();
            collection2.Print();
        }

        static void Lab4()
        {
            Car car = new Car
            {
                Color = "red",
                New = true,
                TopSpeed = 200,
            };
            RuleBuilder<Car> ruleBuilder = new RuleBuilder<Car>();

            ruleBuilder
                .AddRule(car => car.New, isNew => (bool)isNew)
                .AddRule(car => car.TopSpeed, topSpeed => (int)topSpeed > 280)
                .AddRule(car => car.Color, color => (string)color == "red");

            bool succeeded = true;
            try
            {
                ruleBuilder.Head.Handle(car);
            }
            catch (OperationCanceledException)
            {
                succeeded = false;
            }
            Console.WriteLine("Validation " + (succeeded ? "succeeded" : "failed"));
        }
    }
}
