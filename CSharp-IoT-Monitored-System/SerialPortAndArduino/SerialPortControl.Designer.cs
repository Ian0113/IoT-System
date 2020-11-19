namespace SerialPortAndArduino
{
    partial class SerialPortControl
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
            this.lb_serialPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_serialPort
            // 
            this.lb_serialPort.AutoSize = true;
            this.lb_serialPort.Location = new System.Drawing.Point(29, 12);
            this.lb_serialPort.Name = "lb_serialPort";
            this.lb_serialPort.Size = new System.Drawing.Size(55, 21);
            this.lb_serialPort.TabIndex = 3;
            this.lb_serialPort.Text = "label1";
            this.lb_serialPort.DoubleClick += new System.EventHandler(this.SerialPortControl_DoubleClick);
            this.lb_serialPort.MouseEnter += new System.EventHandler(this.SerialPortControl_MouseEnter);
            this.lb_serialPort.MouseLeave += new System.EventHandler(this.SerialPortControl_MouseLeave);
            // 
            // SerialPortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_serialPort);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SerialPortControl";
            this.Size = new System.Drawing.Size(350, 50);
            this.Load += new System.EventHandler(this.SerialPortControl_Load);
            this.DoubleClick += new System.EventHandler(this.SerialPortControl_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.SerialPortControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SerialPortControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_serialPort;
    }
}
