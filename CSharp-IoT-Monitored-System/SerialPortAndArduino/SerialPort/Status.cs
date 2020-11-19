using System.Collections.Generic;
using System.Linq;


class Status
{
    /// <summary>
    /// 是否有新的SerialPort
    /// </summary>
    public bool IsAdd
    {
        get => _isAdd;
    }
    private bool _isAdd = false;

    /// <summary>
    /// 是否有已移除的SerialPort
    /// </summary>
    public bool IsRemove
    {
        get => _isRemove;
    }
    private bool _isRemove = false;

    /// <summary>
    /// 取得新增列表
    /// </summary>
    public List<string> AddSerialPorts
    {
        get
        {
            if (IsAdd)
                return _addSerialPorts;
            return new List<string>();
        }
    }
    private List<string> _addSerialPorts;

    /// <summary>
    /// 取得移除列表
    /// </summary>
    public List<string> RemoveSerialPorts
    {
        get
        {
            if (IsRemove)
                return _removeSerialPorts;
            return new List<string>();
        }
    }
    private List<string> _removeSerialPorts;

    /// <summary>
    /// 取得SerialPort列表
    /// 執行Update()可更新
    /// </summary>
    public List<string> SerialPortNames
    {
        get => _serialPortNames;
    }
    private List<string> _serialPortNames;

    public Status()
    {
        _serialPortNames = new List<string>();
    }

    /// <summary>
    /// 執行後能將現階段SerialPort更新
    /// </summary>
    public void Update()
    {
        foreach (string portName in _addSerialPorts)
        {
            _serialPortNames.Add(portName);
        }
        foreach (string portName in _removeSerialPorts)
        {
            _serialPortNames.Remove(portName);
        }
        _isAdd = false;
        _isRemove = false;
        _addSerialPorts = null;
        _removeSerialPorts = null;
    }

    /// <summary>
    /// 執行後能檢查是否有新增或移除SerialPort
    /// 可透過IsAdd及IsRemove檢查
    /// </summary>
    public void Check()
    {
        _isAdd = checkSerialPortAdd();
        _isRemove = checkSerialPortRemove();
    }

    /// <summary>
    /// 執行後能將_addSerialPorts更新
    /// </summary>
    /// <returns>將會回傳是否有新的SerialPort</returns>
    private bool checkSerialPortAdd()
    {
        _addSerialPorts = new List<string>();
        List<string> newPortNames = getSerialPort();
        foreach (string oldPortName in _serialPortNames)
        {
            if (newPortNames.Contains(oldPortName))
                newPortNames.Remove(oldPortName);
        }
        foreach (string newPortName in newPortNames)
        {
            if (!_serialPortNames.Contains(newPortName))
            {
                _addSerialPorts.Add(newPortName);
                _isAdd = true;
            }
        }
        return _isAdd;
    }

    /// <summary>
    /// 執行後能將_removeSerialPorts更新
    /// </summary>
    /// <returns>將會回傳是否有移除SerialPort</returns>
    private bool checkSerialPortRemove()
    {
        _removeSerialPorts = new List<string>();
        List<string> newPortNames = getSerialPort();
        foreach (string oldPortName in _serialPortNames)
        {
            if (!newPortNames.Contains(oldPortName))
            {
                _removeSerialPorts.Add(oldPortName);
                _isRemove = true;
            }
        }
        return _isRemove;
    }

    private List<string> getSerialPort()
    {
        List<string> allPortNames = System.IO.Ports.SerialPort.GetPortNames().OfType<string>().ToList();
        allPortNames.Remove("COM1");
        return allPortNames;
    }
}

