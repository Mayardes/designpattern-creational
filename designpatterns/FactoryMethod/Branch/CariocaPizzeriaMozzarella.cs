namespace FactoryMethod.Branch
{
    public class CariocaPizzeriaMozzarella : Pizza
    {
        public CariocaPizzeriaMozzarella()
        {
            Name = "Carioca Mozzarella Pizza";
            Pasta = "Traditional Carioca Pasta";
            Sauce = "Italian Carioca Tomato Sauce";
            Ingredients.Add("Grated Parmesan cheese");
            Ingredients.Add("Black Olives");
        }
    }
}
