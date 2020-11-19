using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialPortAndArduino.Boards.Meters;

namespace SerialPortAndArduino
{
    public partial class MeterControl : UserControl
    {
        private AMeter _aMeter;

        public MeterControl(AMeter aMeter)
        {
            InitializeComponent();
            _aMeter = aMeter;
        }

        private void MeterControl_Load(object sender, EventArgs e)
        {
            lb_meterId.Text = "儀器編號" + _aMeter.Id + " :";
            tb_b.Text = _aMeter._statusValMax.ToString();
            tb_s.Text = _aMeter._statusValMin.ToString();
            tb_name.Text = _aMeter.name;
            if (_aMeter.IsControlable)
            {
                chart1.ChartAreas[0].AxisY.Maximum = 2;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
            }
            else
            {
                chart1.ChartAreas[0].AxisY.Maximum = 100;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
            }
            t_update.Enabled = true;
        }

        private void t_update_Tick(object sender, EventArgs e)
        {
            lb_type.Text = _aMeter.IsControlable ? (_aMeter.name + "開關") : (_aMeter.name + "感測器");
            lb_statusVal.Text = _aMeter.StatusVals[_aMeter.StatusVals.Count - 1].ToString();
            chart1.Series[0].Points.ResumeUpdates();
            chart1.Series[0].Points.Clear();
            foreach (var item in _aMeter.StatusVals)
            {
                chart1.Series[0].Points.AddY(item);
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            _aMeter.name = tb_name.Text;
        }

        private void tb_s_TextChanged(object sender, EventArgs e)
        {
            if(byte.TryParse(tb_s.Text, out byte result))
            {
                _aMeter._statusValMin = result;
            }
            else
            {
                _aMeter._statusValMin = null;
                tb_s.Text = "";
            }
        }

        private void tb_b_TextChanged(object sender, EventArgs e)
        {
            if (byte.TryParse(tb_b.Text, out byte result))
            {
                _aMeter._statusValMax = result;
            }
            else
            {
                _aMeter._statusValMax = null;
                tb_b.Text = "";
            }
        }
    }
}
