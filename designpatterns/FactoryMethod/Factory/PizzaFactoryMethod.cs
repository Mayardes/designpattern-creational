using FactoryMethod.Branch;

namespace FactoryMethod.Factory
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza MountPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            return pizza;
        }
        public abstract Pizza CreatePizza(string type);
    }
    public class PaulistaPizzaFactory : PizzaFactoryMethod
    {
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("M"))
                return new PaulistaPizzeriaMozzarella();
            else if (type.Equals("C"))
                return new PaulistaPizzeriaCalabreza();
            else
                throw new NotImplementedException();
        }
    }
    public class CariocaPizzaFactory : PizzaFactoryMethod
    {
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("M"))
                return new CariocaPizzeriaMozzarella();
            else if (type.Equals("C"))
                return new CariocaPizzeriaCalabreza();
            else
                throw new NotImplementedException();
        }
    }
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CreatePizza(string local)
        {
            PizzaFactoryMethod _pizzaFactoryMethod;
            switch (local)
            {
                case "S":
                    _pizzaFactoryMethod = new PaulistaPizzaFactory();
                    break;
                case "R":
                    _pizzaFactoryMethod = new CariocaPizzaFactory();
                    break;
                default:
                    throw new Exception();
            }
            return _pizzaFactoryMethod;
        }
    }
}
