namespace SerialPortAndArduino
{
    partial class BoardControl
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
            this.lb_boardId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_update = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rc_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_meterCnt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_boardId
            // 
            this.lb_boardId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_boardId.AutoSize = true;
            this.lb_boardId.Location = new System.Drawing.Point(108, 21);
            this.lb_boardId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_boardId.Name = "lb_boardId";
            this.lb_boardId.Size = new System.Drawing.Size(23, 21);
            this.lb_boardId.TabIndex = 0;
            this.lb_boardId.Text = "N";
            this.lb_boardId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lb_boardId.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BoardControl_MouseDoubleClick);
            this.lb_boardId.MouseEnter += new System.EventHandler(this.BoardControl_MouseEnter);
            this.lb_boardId.MouseLeave += new System.EventHandler(this.BoardControl_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "板子編號 :";
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BoardControl_MouseDoubleClick);
            this.label1.MouseEnter += new System.EventHandler(this.BoardControl_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.BoardControl_MouseLeave);
            // 
            // t_update
            // 
            this.t_update.Interval = 5;
            this.t_update.Tick += new System.EventHandler(this.t_update_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rc_setting});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.ShowItemToolTips = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(74, 26);
            // 
            // rc_setting
            // 
            this.rc_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rc_setting.ForeColor = System.Drawing.Color.Gray;
            this.rc_setting.Name = "rc_setting";
            this.rc_setting.Size = new System.Drawing.Size(73, 22);
            this.rc_setting.Text = "設定";
            this.rc_setting.Click += new System.EventHandler(this.rc_setting_Click);
            // 
            // lb_meterCnt
            // 
            this.lb_meterCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_meterCnt.AutoSize = true;
            this.lb_meterCnt.Location = new System.Drawing.Point(108, 54);
            this.lb_meterCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_meterCnt.Name = "lb_meterCnt";
            this.lb_meterCnt.Size = new System.Drawing.Size(23, 21);
            this.lb_meterCnt.TabIndex = 0;
            this.lb_meterCnt.Text = "N";
            this.lb_meterCnt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lb_meterCnt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BoardControl_MouseDoubleClick);
            this.lb_meterCnt.MouseEnter += new System.EventHandler(this.BoardControl_MouseEnter);
            this.lb_meterCnt.MouseLeave += new System.EventHandler(this.BoardControl_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "儀器數量 :";
            this.label3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BoardControl_MouseDoubleClick);
            this.label3.MouseEnter += new System.EventHandler(this.BoardControl_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.BoardControl_MouseLeave);
            // 
            // BoardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_meterCnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_boardId);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BoardControl";
            this.Size = new System.Drawing.Size(255, 199);
            this.Load += new System.EventHandler(this.BoardControl_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BoardControl_MouseDoubleClick);
            this.MouseEnter += new System.EventHandler(this.BoardControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.BoardControl_MouseLeave);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_boardId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer t_update;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rc_setting;
        private System.Windows.Forms.Label lb_meterCnt;
        private System.Windows.Forms.Label label3;
    }
}
