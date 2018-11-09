namespace CommandPattern
{
    public class CeilingFanMediumCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private int _preSpeed;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _preSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Medium();
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
