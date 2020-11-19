using System.Collections.Generic;

namespace SerialPortAndArduino.Boards.Meters
{
    class Switch : AMeter
    {
        public Switch(byte id) : base(id, true)
        {
            _statusValMax = 1;
            _statusValMin = 0;
            _statusValsCountMax = 20;
        }
    }
}
