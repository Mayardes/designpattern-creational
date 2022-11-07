namespace FactoryMethod.Branch
{
    public class PaulistaPizzeriaCalabreza : Pizza
    {
        public PaulistaPizzeriaCalabreza()
        {
            Name = "Calabreza pizza paulista with a lot of calabreza";
            Pasta = "Slim Pasta Crunchy";
            Sauce = "Italian Tomato Sauce";
            Ingredients.Add("Special Smoked Calabreza Slices");
            Ingredients.Add("Traditional Italian Parmesan Cheese");
        }

    }
}
