using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortAndArduino.SerialPort
{
    public struct Package
    {
        public bool IsControl { get; set; }
        public byte BoardId { get; set; }
        public byte MeterId { get; set; }
        public bool IsSwitch { get; set; }
        public byte StatusVal { get; set; }
    }
}
