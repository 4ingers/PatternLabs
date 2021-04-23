using System;
using System.Collections.Generic;
using System.Text;
using PatternLabs.Eatery.Products;

namespace PatternLabs.Eatery.Staff
{
    public class Chief
    {
        public Morsel CookThickBurrito(Cooker cooker)
        {
            cooker.PutThinArmenianBread();
            ForceBurrito(cooker);
            return cooker.GetMorsel();
        }

        public Morsel CookThinBurrito(Cooker cooker)
        {
            cooker.PutPita();
            ForceBurrito(cooker);
            return cooker.GetMorsel();
        }

        public Morsel CookThickDoner(Cooker cooker)
        {
            cooker.PutThinArmenianBread();
            ForceDoner(cooker);
            return cooker.GetMorsel();
        }

        public Morsel CookThinDoner(Cooker cooker)
        {
            cooker.PutPita();
            ForceDoner(cooker);
            return cooker.GetMorsel();
        }

        public Morsel CookThickShawarma(Cooker cooker)
        {
            cooker.PutThinArmenianBread();
            ForceShawarma(cooker);
            return cooker.GetMorsel();
        }

        public Morsel CookThinShawarma(Cooker cooker)
        {
            cooker.PutPita();
            ForceShawarma(cooker);
            return cooker.GetMorsel();
        }

        #region Force
        private void ForceBurrito(Cooker cooker)
        {
            cooker.StartBurrito();
            cooker.AddChickenFillet();
            cooker.AddOnion();
        }

        private void ForceDoner(Cooker cooker)
        {
            cooker.StartDoner();
            cooker.AddMincedLamb();
            cooker.AddTomato();
            cooker.AddBellPepper();
        }

        private void ForceShawarma(Cooker cooker)
        {
            cooker.StartShawarma();
            cooker.AddChickenFillet();
            cooker.AddTomato();
            cooker.AddOnion();
        }
        #endregion
    }
}
