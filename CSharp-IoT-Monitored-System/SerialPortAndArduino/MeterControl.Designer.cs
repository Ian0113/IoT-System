namespace SerialPortAndArduino
{
    partial class MeterControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_meterId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.t_update = new System.Windows.Forms.Timer(this.components);
            this.lb_statusVal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_s = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.tb_b);
            this.panel1.Controls.Add(this.tb_s);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.lb_statusVal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 113);
            this.panel1.TabIndex = 0;
            // 
            // lb_meterId
            // 
            this.lb_meterId.AutoSize = true;
            this.lb_meterId.Location = new System.Drawing.Point(5, 5);
            this.lb_meterId.Name = "lb_meterId";
            this.lb_meterId.Size = new System.Drawing.Size(55, 21);
            this.lb_meterId.TabIndex = 1;
            this.lb_meterId.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "目前數值 :";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(99, 4);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(23, 21);
            this.lb_type.TabIndex = 0;
            this.lb_type.Text = "N";
            // 
            // t_update
            // 
            this.t_update.Interval = 10;
            this.t_update.Tick += new System.EventHandler(this.t_update_Tick);
            // 
            // lb_statusVal
            // 
            this.lb_statusVal.AutoSize = true;
            this.lb_statusVal.Location = new System.Drawing.Point(198, 24);
            this.lb_statusVal.Name = "lb_statusVal";
            this.lb_statusVal.Size = new System.Drawing.Size(23, 21);
            this.lb_statusVal.TabIndex = 0;
            this.lb_statusVal.Text = "N";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "儀器名稱 :";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.ForeColor = System.Drawing.Color.White;
            this.tb_name.Location = new System.Drawing.Point(198, 47);
            this.tb_name.MaxLength = 15;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(127, 22);
            this.tb_name.TabIndex = 0;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "數值過濾 :";
            // 
            // tb_s
            // 
            this.tb_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tb_s.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_s.ForeColor = System.Drawing.Color.White;
            this.tb_s.Location = new System.Drawing.Point(198, 71);
            this.tb_s.MaxLength = 5;
            this.tb_s.Name = "tb_s";
            this.tb_s.Size = new System.Drawing.Size(46, 22);
            this.tb_s.TabIndex = 1;
            this.tb_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_s.TextChanged += new System.EventHandler(this.tb_s_TextChanged);
            // 
            // tb_b
            // 
            this.tb_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tb_b.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_b.ForeColor = System.Drawing.Color.White;
            this.tb_b.Location = new System.Drawing.Point(279, 71);
            this.tb_b.MaxLength = 5;
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(46, 22);
            this.tb_b.TabIndex = 2;
            this.tb_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_b.TextChanged += new System.EventHandler(this.tb_b_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "~";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(-15, 17);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Yellow;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(128, 92);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // MeterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_meterId);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "MeterControl";
            this.Size = new System.Drawing.Size(330, 131);
            this.Load += new System.EventHandler(this.MeterControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_meterId;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer t_update;
        private System.Windows.Forms.Label lb_statusVal;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_s;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
