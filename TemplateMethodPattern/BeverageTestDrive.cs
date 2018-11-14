using System;

namespace TemplateMethodPattern
{
    class BeverageTestDrive
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("Making tea...");
            tea.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffee.PrepareRecipe();

            Console.Read();
        }
    }
}
