namespace FactoryMethod.Branch
{
    public class PaulistaPizzeriaMozzarella : Pizza
    {
        public PaulistaPizzeriaMozzarella()
        {
            Name = "Sao Paulo Mozzarella Pizza";
            Pasta = "Paulista Slim Crunchy Pasta ";
            Sauce = "Italian Tomato Sauce";
            Ingredients.Add("Parmesan Cheese");
            Ingredients.Add("Green Olives");
        }
    }
}
