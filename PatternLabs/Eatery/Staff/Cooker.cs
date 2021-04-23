using PatternLabs.Eatery.Products;

namespace PatternLabs.Eatery.Staff
{
    public class Cooker
    {
        protected Shell shell;
        protected Morsel morsel;

        public Morsel GetMorsel() => morsel;

        public void PutThinArmenianBread() => shell = new ThinArmenianBread();
        public void PutPita() => shell = new Pita();

        public void StartBurrito() => morsel = new Burrito(shell);
        public void StartDoner() => morsel = new Doner(shell);
        public void StartShawarma() => morsel = new Shawarma(shell);

        public void AddBellPepper() => morsel.AddIngredient(Ingredients.BELL_PEPPER);
        public void AddChickenFillet() => morsel.AddIngredient(Ingredients.CHICKEN_FILLET);
        public void AddMincedLamb() => morsel.AddIngredient(Ingredients.MINCED_LAMB);
        public void AddOnion() => morsel.AddIngredient(Ingredients.ONION);
        public void AddTomato() => morsel.AddIngredient(Ingredients.TOMATO);

    }
}