using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            if (answer.ToLower().StartsWith('y'))
            {
                return true;
            }
            return false;
        }

        private string GetUserInput()
        {
            string answer = string.Empty;

            Console.Write("Would you like milk and sugar with you coffee (y/n)? ");

            answer = Console.ReadLine();

            return answer;
        }
    }
}
