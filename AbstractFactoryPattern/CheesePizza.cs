using System;

namespace AbstractFactoryPattern
{
    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + _name);
            _dough = _ingredientFactory.CreateDough();
            Console.WriteLine("Tossing " + _dough);
            _sauce = _ingredientFactory.CreateSauce();
            Console.WriteLine("Adding " + _sauce);
            _cheese = _ingredientFactory.CreateCheese();
            Console.WriteLine("Adding " + _cheese);
        }
    }
}
