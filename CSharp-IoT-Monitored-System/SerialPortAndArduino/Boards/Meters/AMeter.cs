using System.Collections.Generic;

namespace SerialPortAndArduino.Boards.Meters
{
    public abstract class AMeter
    {
        public string name { get; set; }
        private byte _id;
        public byte Id => _id;
        public byte? _statusValMax = null;
        public byte? _statusValMin = null;
        public uint? _statusValsCountMax = null;
        private bool _isControlable;
        public bool IsControlable => _isControlable;
        private List<byte> _statusVals;
        public List<byte> StatusVals { get => _statusVals; }
        public AMeter(byte Id, bool IsControlable)
        {
            _id = Id;
            _isControlable = IsControlable;
            _statusVals = new List<byte>();
        }
        public virtual void AddStatusVal(byte val)
        {
            if (_statusValMax != null & _statusValMin == null)
            {
                if (_statusValMax >= val) _statusVals.Add(val);
            }
            else if (_statusValMax == null & _statusValMin != null)
            {
                if (val >= _statusValMin) _statusVals.Add(val);
            }
            else if (_statusValMax != null & _statusValMin != null)
            {
                if (_statusValMax >= val & val >= _statusValMin) _statusVals.Add(val);
            }
            else
            {
                _statusVals.Add(val);
            }

            if (_statusValsCountMax != null)
            {
                if (_statusVals.Count == _statusValsCountMax + 1)
                {
                    _statusVals.RemoveAt(0);
                }
                else if (_statusVals.Count > _statusValsCountMax)
                {
                    for (int i = 0; i < _statusVals.Count - _statusValsCountMax; i++)
                        _statusVals.RemoveAt(i);
                }
            }
        }
        public virtual bool CheckId(byte Id)
        {
            return _id == Id;
        }
    }
}
