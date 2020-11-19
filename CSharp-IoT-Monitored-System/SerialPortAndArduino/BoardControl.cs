using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialPortAndArduino.SerialPort;
using SerialPortAndArduino.Boards;

namespace SerialPortAndArduino
{
    public partial class BoardControl : UserControl
    {
        private Board _board;
        private MonitorForm _monitorForm;

        public BoardControl(Board board)
        {
            InitializeComponent();
            _board = board;
        }

        public void Close()
        {
            _monitorForm.Visible = false;
            try
            {
                _monitorForm.Dispose();
            }
            catch (Exception)
            {
            }
            this.Dispose();
        }

        private void BoardControl_Load(object sender, EventArgs e)
        {
            lb_boardId.Text = _board.Id.ToString();
            _monitorForm = new MonitorForm(_board);
            t_update.Enabled = true;
        }

        private void t_update_Tick(object sender, EventArgs e)
        {
            lb_meterCnt.Text = _board.Meters.Count.ToString();
        }

        private void BoardControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(this.BackColor.R + 10, this.BackColor.G + 10, this.BackColor.B + 10);
        }

        private void BoardControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(this.BackColor.R - 10, this.BackColor.G - 10, this.BackColor.B - 10);
        }

        private void rc_setting_Click(object sender, EventArgs e)
        {
            
        }

        private void BoardControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_monitorForm.Created) _monitorForm.Visible = true;
            else _monitorForm.Show();
        }
    }
}
