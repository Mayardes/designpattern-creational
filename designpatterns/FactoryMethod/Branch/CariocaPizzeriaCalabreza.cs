namespace FactoryMethod.Branch
{
    public class CariocaPizzeriaCalabreza : Pizza
    {
        public CariocaPizzeriaCalabreza()
        {
            Name = "Carioca Calabreza Pizza with onion";
            Pasta = "Traditional Carioca Pasta";
            Sauce = "Italian Carioca Tomato Sauce";
            Ingredients.Add("Special Smoked Calabreza Slices");
            Ingredients.Add("Traditional Italian Parmesan Cheese");
        }
    }
}
