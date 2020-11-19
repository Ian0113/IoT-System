namespace SerialPortAndArduino
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p_header = new System.Windows.Forms.Panel();
            this.p_top = new System.Windows.Forms.Panel();
            this.lb_header_title = new System.Windows.Forms.Label();
            this.b_header_cloase = new System.Windows.Forms.Button();
            this.p_footer = new System.Windows.Forms.Panel();
            this.t_update_serial = new System.Windows.Forms.Timer(this.components);
            this.p_content = new System.Windows.Forms.Panel();
            this.fp_content_body = new System.Windows.Forms.FlowLayoutPanel();
            this.p_content_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.p_header.SuspendLayout();
            this.p_top.SuspendLayout();
            this.p_content.SuspendLayout();
            this.p_content_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_header
            // 
            this.p_header.Controls.Add(this.p_top);
            this.p_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_header.Location = new System.Drawing.Point(0, 0);
            this.p_header.MaximumSize = new System.Drawing.Size(350, 100);
            this.p_header.MinimumSize = new System.Drawing.Size(350, 100);
            this.p_header.Name = "p_header";
            this.p_header.Size = new System.Drawing.Size(350, 100);
            this.p_header.TabIndex = 2;
            // 
            // p_top
            // 
            this.p_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.p_top.Controls.Add(this.lb_header_title);
            this.p_top.Controls.Add(this.b_header_cloase);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(350, 28);
            this.p_top.TabIndex = 3;
            this.p_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseDown);
            this.p_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseMove);
            this.p_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseUp);
            // 
            // lb_header_title
            // 
            this.lb_header_title.AutoSize = true;
            this.lb_header_title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_header_title.Location = new System.Drawing.Point(3, 2);
            this.lb_header_title.Name = "lb_header_title";
            this.lb_header_title.Size = new System.Drawing.Size(170, 22);
            this.lb_header_title.TabIndex = 0;
            this.lb_header_title.Text = "串列埠與硬體溝通列表";
            this.lb_header_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseDown);
            this.lb_header_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseMove);
            this.lb_header_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseUp);
            // 
            // b_header_cloase
            // 
            this.b_header_cloase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_header_cloase.FlatAppearance.BorderSize = 0;
            this.b_header_cloase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_header_cloase.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b_header_cloase.Location = new System.Drawing.Point(321, -2);
            this.b_header_cloase.Name = "b_header_cloase";
            this.b_header_cloase.Size = new System.Drawing.Size(30, 30);
            this.b_header_cloase.TabIndex = 2;
            this.b_header_cloase.Text = "x";
            this.b_header_cloase.UseVisualStyleBackColor = true;
            this.b_header_cloase.Click += new System.EventHandler(this.b_header_cloase_Click);
            // 
            // p_footer
            // 
            this.p_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_footer.Location = new System.Drawing.Point(0, 570);
            this.p_footer.MaximumSize = new System.Drawing.Size(350, 100);
            this.p_footer.MinimumSize = new System.Drawing.Size(350, 30);
            this.p_footer.Name = "p_footer";
            this.p_footer.Size = new System.Drawing.Size(350, 30);
            this.p_footer.TabIndex = 3;
            // 
            // t_update_serial
            // 
            this.t_update_serial.Interval = 500;
            this.t_update_serial.Tick += new System.EventHandler(this.t_update_serial_Tick);
            // 
            // p_content
            // 
            this.p_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.p_content.Controls.Add(this.fp_content_body);
            this.p_content.Controls.Add(this.p_content_header);
            this.p_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_content.Location = new System.Drawing.Point(0, 100);
            this.p_content.Name = "p_content";
            this.p_content.Size = new System.Drawing.Size(350, 470);
            this.p_content.TabIndex = 4;
            // 
            // fp_content_body
            // 
            this.fp_content_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fp_content_body.Location = new System.Drawing.Point(0, 30);
            this.fp_content_body.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.fp_content_body.Name = "fp_content_body";
            this.fp_content_body.Size = new System.Drawing.Size(350, 440);
            this.fp_content_body.TabIndex = 1;
            // 
            // p_content_header
            // 
            this.p_content_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.p_content_header.Controls.Add(this.label1);
            this.p_content_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_content_header.Location = new System.Drawing.Point(0, 0);
            this.p_content_header.MaximumSize = new System.Drawing.Size(350, 30);
            this.p_content_header.MinimumSize = new System.Drawing.Size(350, 30);
            this.p_content_header.Name = "p_content_header";
            this.p_content_header.Size = new System.Drawing.Size(350, 30);
            this.p_content_header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "列表";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(350, 600);
            this.Controls.Add(this.p_content);
            this.Controls.Add(this.p_header);
            this.Controls.Add(this.p_footer);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(350, 600);
            this.MinimumSize = new System.Drawing.Size(350, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串列埠與硬體溝通列表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_header.ResumeLayout(false);
            this.p_top.ResumeLayout(false);
            this.p_top.PerformLayout();
            this.p_content.ResumeLayout(false);
            this.p_content_header.ResumeLayout(false);
            this.p_content_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_header;
        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.Label lb_header_title;
        private System.Windows.Forms.Button b_header_cloase;
        private System.Windows.Forms.Panel p_footer;
        private System.Windows.Forms.Timer t_update_serial;
        private System.Windows.Forms.Panel p_content;
        private System.Windows.Forms.FlowLayoutPanel fp_content_body;
        private System.Windows.Forms.Panel p_content_header;
        private System.Windows.Forms.Label label1;
    }
}

