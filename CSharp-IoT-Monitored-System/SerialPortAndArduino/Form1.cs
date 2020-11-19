using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortAndArduino
{
    public partial class Form1 : Form
    {
        int _lastMouseX, _lastMouseY;
        bool _isMov = false;
        Status _serialPortStatus;
        public Form1()
        {
            InitializeComponent();
        }
        #region p_header can move form
        private void p_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isMov = true;
                _lastMouseX = e.X;
                _lastMouseY = e.Y;
            }
        }

        private void p_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMov)
                this.Location = new Point(this.Left + e.X - this._lastMouseX, this.Top + e.Y - this._lastMouseY);
        }

        private void p_top_MouseUp(object sender, MouseEventArgs e)
        {
            _isMov = false;
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        private void b_header_cloase_Click(object sender, EventArgs e)
        {
            this.Close();
            //Environment.Exit(Environment.ExitCode);
            //Application.Exit();
        }

        private void t_update_serial_Tick(object sender, EventArgs e)
        {
            _serialPortStatus.Check();
            if (_serialPortStatus.IsAdd)
            {
                foreach (var item in _serialPortStatus.AddSerialPorts)
                {
                    SerialPortControl sc = new SerialPortControl(item);
                    fp_content_body.Controls.Add(sc);
                }
            }
            if (_serialPortStatus.IsRemove)
            {
                foreach (SerialPortControl sc in fp_content_body.Controls)
                {
                    if (_serialPortStatus.RemoveSerialPorts.Contains(sc.SerialPortName))
                    {
                        fp_content_body.Controls.Remove(sc);
                    }
                }
            }
            _serialPortStatus.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPortStatus = new Status();
            _serialPortStatus.Check();
            _serialPortStatus.Update();
            foreach (var item in _serialPortStatus.SerialPortNames)
            {
                SerialPortControl sc = new SerialPortControl(item);
                fp_content_body.Controls.Add(sc);
            }
            t_update_serial.Enabled = true;
        }
    }
}
