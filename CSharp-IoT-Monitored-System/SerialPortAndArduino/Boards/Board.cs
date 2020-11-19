using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerialPortAndArduino.Boards.Meters;

namespace SerialPortAndArduino.Boards
{
    public class Board
    {
        private byte _id;
        public byte Id => _id;

        private List<AMeter> _meters;
        public List<AMeter> Meters => _meters;

        public Board(byte id)
        {
            _id = id;
            _meters = new List<AMeter>();
        }

        public bool SetMeter(byte meterId, bool isSwitch)
        {
            if (!GetMeter(meterId, out AMeter m))
            {
                if(isSwitch)
                    _meters.Add(new Switch(meterId));
                else
                    _meters.Add(new Sensor(meterId));
                return true;
            }
            return false;
        }

        public bool GetMeter(byte meterId, out AMeter meter)
        {
            foreach (var m in _meters)
            {
                if (m.CheckId(meterId))
                {
                    meter = m;
                    return true;
                }
            }
            meter = null;
            return false;
        }

        public bool CheckId(byte boardId)
        {
            return boardId == _id;
        }
    }
}
