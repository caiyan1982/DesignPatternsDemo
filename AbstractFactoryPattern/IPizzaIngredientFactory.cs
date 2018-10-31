namespace AbstractFactoryPattern
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();

        ISauce CreateSauce();

        ICheese CreateCheese();
    }
}
