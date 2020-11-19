using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialPortAndArduino.SerialPort;
using SerialPortAndArduino.Boards;

namespace SerialPortAndArduino
{
    public partial class UserForm : Form
    {
        int _lastMouseX, _lastMouseY;
        bool _isMov = false;
        string _serialPortName;
        Connection _connection;
        List<Board> _boards;

        public UserForm(string serialPortName)
        {
            InitializeComponent();
            _serialPortName = serialPortName;
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
        private void b_header_cloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in fp_board.Controls)
            {
                if (item is BoardControl)
                {
                    ((BoardControl)item).Close();
                }
            }
            _connection.DisConnect();
            this.Dispose();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            _connection = new Connection(_serialPortName);
            _boards = new List<Board>();
            if (!_connection.Connect()) this.Dispose();
            this.Text = lb_serialPortName.Text = _serialPortName;
            byte[] b = { 255, 254 };
            _connection.Write(b);
            t_update.Enabled = true;
        }

        private void t_update_Tick(object sender, EventArgs e)
        {
            _connection.ReadBytes();
            _connection.Unpackage();
            foreach (var p in _connection.Packages)
            {
                if (!p.IsControl)
                {
                    if (GetBoard(p.BoardId, out var b))
                    {
                        if (b.GetMeter(p.MeterId, out var result))
                        {
                            result.AddStatusVal(p.StatusVal);
                        }
                        else
                        {
                            b.SetMeter(p.MeterId, p.IsSwitch);
                            if (b.GetMeter(p.MeterId, out var meter))
                            {
                                meter.AddStatusVal(p.StatusVal);
                            }
                        }
                    }
                    else
                    {
                        Board board = new Board(p.BoardId);
                        board.SetMeter(p.MeterId, p.IsSwitch);
                        if (board.GetMeter(p.MeterId, out var meter))
                        {
                            meter.AddStatusVal(p.StatusVal);
                        }
                        _boards.Add(board);
                        fp_board.Controls.Add(new BoardControl(board));
                    }
                }
            }
            _connection.Send();
        }

        private bool GetBoard(byte boardId, out Board board)
        {
            foreach (var b in _boards)
            {
                if (b.CheckId(boardId))
                {
                    board = b;
                    return true;
                }
            }
            board = null;
            return false;
        }
    }
}
