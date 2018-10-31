using System;

namespace AbstractFactoryPattern
{
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
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
