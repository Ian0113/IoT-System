using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialPortAndArduino.Boards;

namespace SerialPortAndArduino
{
    public partial class MonitorForm : Form
    {
        int _lastMouseX, _lastMouseY;
        bool _isMov = false;
        Board _board;

        public MonitorForm(Board board)
        {
            InitializeComponent();
            _board = board;
        }

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

        private void MonitorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            lb_board.Text = "板子 " + _board.Id.ToString();
            this.Text = "板子 " + _board.Id.ToString();
            this.Height = (_board.Meters.Count / 2 + _board.Meters.Count % 2) * 140 + 33;
            foreach (var item in _board.Meters)
            {
                fp_meters.Controls.Add(new MeterControl(item));
            }
        }

        private void b_header_cloase_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
