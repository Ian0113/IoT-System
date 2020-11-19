using System.Collections.Generic;

namespace SerialPortAndArduino.Boards.Meters
{
    class Sensor : AMeter
    {
        public Sensor(byte id) : base(id, false)
        {
            _statusValMax = 100;
            _statusValMin = 0;
            _statusValsCountMax = 20;
        }
    }
}
