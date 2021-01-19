namespace NutriLife.Core.Domain
{
    public class Food
    {
        public Food(string description, int calorie)
        {
            Description = description;
            Calorie = calorie;
        }

        public string Description { get; private set; }
        public int Calorie { get; private set; }

       
    }
}