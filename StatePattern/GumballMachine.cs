using System;

namespace StatePattern
{
    public class GumballMachine
    {
        private IState _soldOutState;
        private IState _noQuarterState;
        private IState _hasQuarterState;
        private IState _soldState;
        private IState _winnerState;
        private IState _state;
        private int _count = 0;

        public GumballMachine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);
            _count = numberGumballs;
            if (numberGumballs > 0)
            {
                _state = _noQuarterState;
            }
            else
            {
                _state = _soldOutState;
            }
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count != 0)
            {
                _count--;
            }
        }

        public void ReFill(int count)
        {
            _count = count;
            _state = _noQuarterState;
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public IState GetWinnerState()
        {
            return _winnerState;
        }

        public int GetCount()
        {
            return _count;
        }

        public override string ToString()
        {
            string description = string.Format("\nMighty Gumball, Inc.\nInventory: {0} gumballs\nMachine is ", _count);

            if (_count > 0)
            {
                description += "waiting for quarter\n";
            }
            else
            {
                description += "sold out\n";
            }

            return description;
        }
    }
}
