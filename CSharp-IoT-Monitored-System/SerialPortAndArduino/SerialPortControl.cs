using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortAndArduino
{
    public partial class SerialPortControl : UserControl
    {
        public string SerialPortName{ get => _serialPortName; }
        string _serialPortName;
        UserForm userForm = null;

        public SerialPortControl(string name)
        {
            InitializeComponent();
            _serialPortName = name;
        }
        private void SerialPortControl_Load(object sender, EventArgs e)
        {
            lb_serialPort.Text = _serialPortName;
        }
        private void SerialPortControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(this.BackColor.R + 10, this.BackColor.G + 10, this.BackColor.B + 10);
        }
        private void SerialPortControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(this.BackColor.R - 10, this.BackColor.G - 10, this.BackColor.B - 10);
        }
        private void SerialPortControl_DoubleClick(object sender, EventArgs e)
        {
            if (userForm == null) userForm = new UserForm(_serialPortName);
            else if (userForm.IsDisposed) userForm = new UserForm(_serialPortName);
            userForm.Show();
        }
    }
}
