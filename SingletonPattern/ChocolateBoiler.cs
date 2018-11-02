using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;
        private static ChocolateBoiler uniqueInstance;
        private static readonly object syncRoot = new object();

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (syncRoot)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new ChocolateBoiler();
                    }
                }
            }

            return uniqueInstance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Filling...");
                _empty = false;
                _boiled = false;
            }
            else
            {
                Console.WriteLine("filled");
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                Console.WriteLine("Draining...");
                _empty = true;
            }
            else
            {
                Console.WriteLine("empty or no boil");
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                Console.WriteLine("Boiling...");
                _boiled = true;
            }
            else
            {
                Console.WriteLine("empty or boiled");
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }
}
