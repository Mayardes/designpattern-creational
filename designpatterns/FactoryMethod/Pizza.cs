using System.Collections;
using System.Text;

namespace FactoryMethod
{
    public class Pizza
    {
        #nullable disable
        protected string Name;
        protected string Pasta;
        protected string Sauce;

        protected ArrayList Ingredients = new ArrayList();

        public string ToPrepare()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Preparing {Name}");
            sb.AppendLine($"{Pasta}");
            sb.AppendLine($"{Sauce}");
            sb.AppendLine("Ingredients: ");
            foreach(var ingredient in Ingredients)
                sb.AppendLine($"\t {ingredient}");

            sb.AppendLine(ToCook());
            sb.AppendLine(ToSlice());
            sb.AppendLine(ToPack());

            return sb.ToString();
        }
        public virtual string ToCook()
        {
            return $"Cooking the {Name}";
        }
        public virtual string ToSlice()
        {
            return $"Slicing the {Name}";
        }
        public virtual string ToPack()
        {
            return $"Packing the {Name}";
        }
    }
}
