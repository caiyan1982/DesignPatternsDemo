﻿namespace CommandPattern
{
    public class CeilingFanHighCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private int _preSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _preSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.High();
        }

        public void Undo()
        {
            if (_preSpeed == CeilingFan.HIGH)
            {
                _ceilingFan.High();
            }
            else if (_preSpeed == CeilingFan.MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if (_preSpeed == CeilingFan.LOW)
            {
                _ceilingFan.Low();
            }
            else if (_preSpeed == CeilingFan.OFF)
            {
                _ceilingFan.Off();
            }
        }
    }
}
