namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
