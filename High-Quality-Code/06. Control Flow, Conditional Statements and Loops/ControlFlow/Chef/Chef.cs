using System;

namespace Chef
{
    public class Chef
    {
        
        public Chef(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Cut(Vegetables vegetable)
        {
            vegetable.Cut();
        }

        private void Peel(Vegetables vegetable)
        {
            vegetable.Peel();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        

        public void Cook()
        {
            Potato potato = this.GetPotato();
            Peel(potato);
            Cut(potato);

            Carrot carrot = this.GetCarrot();
            Peel(carrot);
            Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

    }
}
