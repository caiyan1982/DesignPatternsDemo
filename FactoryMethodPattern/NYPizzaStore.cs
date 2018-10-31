namespace FactoryMethodPattern
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if(type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
