using System.Collections.Generic;

namespace PatternLabs.Eatery.Products
{
    public enum Ingredients
    {
        BELL_PEPPER,
        CHICKEN_FILLET,
        MINCED_LAMB,
        ONION,
        TOMATO,
    }

    abstract public class Morsel
    {
        protected Shell shell;
        protected List<Ingredients> ingredients = new List<Ingredients>();

        public Morsel(Shell shell) => this.shell = shell;

        public abstract string Nation { get; }

        public string Description()
        {
            string morsel = GetType().Name.ToLower();
            string filling = string.Join(", ", ingredients.ConvertAll(
                ingredient => ingredient.ToString().ToLower().Replace("_", " "))
            );
            return $"It's {Nation}... \n\tSounds like a {morsel} with {filling} wrapped in {shell}!";
        }

        public void AddIngredient(Ingredients ingredient) => ingredients.Add(ingredient);

        public void Tell() => System.Console.WriteLine(Description());
    }

    public class Burrito : Morsel
    {
        public Burrito(Shell shell) : base(shell)
        {
        }

        public override string Nation => "spanish";
    }

    public class Doner : Morsel
    {
        public Doner(Shell shell) : base(shell)
        {
        }

        public override string Nation => "german";
    }

    public class Shawarma : Morsel
    {
        public Shawarma(Shell shell) : base(shell)
        {
        }

        public override string Nation => "russian";
    }
}