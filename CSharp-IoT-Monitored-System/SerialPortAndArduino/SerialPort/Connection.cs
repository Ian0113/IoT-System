using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortAndArduino.SerialPort
{
    public class Connection
    {
        private bool _isRead = false;
        private bool _isUnPack = false;
        private bool _isSend = false;
        private List<byte> _package;
        private List<Package> _packages;
        public List<Package> Packages => _packages;
        private List<byte> _readyToSend;

        public System.IO.Ports.SerialPort SerialPort => _serialPort;
        private System.IO.Ports.SerialPort _serialPort;

        public Connection(string serialPortName)
        {
            _serialPort = new System.IO.Ports.SerialPort();
            _serialPort.BaudRate = 9600;
            _serialPort.PortName = serialPortName;
            _serialPort.ReadTimeout = 1;
            _package = new List<byte>();
            _packages = new List<Package>();
            _readyToSend = new List<byte>();
        }

        /// <summary>
        /// 嘗試連接SerialPort
        /// 連接成功回true
        /// </summary>
        /// <returns>回傳成功與否</returns>
        public bool Connect()
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                    _serialPort.DiscardInBuffer();
                }
                else
                    return false;
                return true;
            }
            catch (System.UnauthorizedAccessException)
            {
                // 重複連接
                return false;
            }
            catch (Exception e)
            {

                Console.WriteLine("SerialPortConnection.Connect ->" + e);
                return false;
            }
        }

        /// <summary>
        /// 嘗試斷開與SerialPort連接
        /// 斷開成功為true
        /// </summary>
        /// <returns>回傳成功與否</returns>
        public bool DisConnect()
        {
            try
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();
                else
                    return false;
                return true;
            }
            catch (System.IO.IOException)
            {
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("SerialPortConnection.DisConnect ->" + e);
                return false;
            }
        }
        public bool Write(byte[] bytes)
        {
            try
            {
                _serialPort.Write(bytes, 0, bytes.Length);
                return true;
            }
            catch (System.IO.IOException)
            {
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("SerialPortConnection.Write ->" + e);
                return false;
            }
        }
        public bool Read(out byte result)
        {
            try
            {
                byte[] buf = new byte[1];
                _serialPort.Read(buf, 0, 1);
                result = buf[0];
                return true;
            }
            catch (System.IO.IOException)
            {
                result = new byte();
                return false;
            }
            catch (System.TimeoutException)
            {
                // 作業逾時
                result = new byte();
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("SerialPortConnection.Read ->" + e);
                result = new byte();
                return false;
            }
        }

        public void ReadBytes()
        {
            if ((!_isSend) & (!_isUnPack) & Read(out byte result))
            {
                if ((!_isRead) & result == 255)
                {
                    _isRead = true;
                }
                else if (_isRead & result == 254)
                {
                    _isRead = false;
                    _isUnPack = true;
                }
                else if (_isRead & (result >= 0) & (result <= 253))
                {
                    _package.Add(result);
                }
                else
                {
                    _package.Clear();
                    _isRead = false;
                }
            }
        }
        public void Send()
        {
            if (_isSend)
            {
                List<byte> send = new List<byte>();
                send.Add(255);
                send.AddRange(_readyToSend);
                send.Add(254);
                Write(send.ToArray());
                _readyToSend.Clear();
                _packages.Clear();
                _isSend = false;
            }
        }
        public void Unpackage()
        {
            if (_isUnPack & _package.Count > 0)
            {
                for (int i = 0; i < _package.Count; i += 2)
                {
                    Package p = new Package();
                    p.IsControl = ((byte)((_package[i] & 128) >> 7)) == 1;
                    p.BoardId = (byte)((_package[i] & 112) >> 4);
                    p.IsSwitch = ((byte)((_package[i] & 8) >> 3)) == 1;
                    p.MeterId = (byte)(_package[i] & 7);
                    p.StatusVal = _package[i + 1];
                    _packages.Add(p);
                }
                _package.Clear();
                _isUnPack = false;
                _isSend = true;
            }
        }

        public void AddToSend(List<byte> toSend)
        {
            _readyToSend.AddRange(toSend);
        }
    }
}
