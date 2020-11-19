namespace SerialPortAndArduino
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p_top = new System.Windows.Forms.Panel();
            this.lb_serialPortName = new System.Windows.Forms.Label();
            this.lb_header_title = new System.Windows.Forms.Label();
            this.b_header_cloase = new System.Windows.Forms.Button();
            this.t_update = new System.Windows.Forms.Timer(this.components);
            this.fp_board = new System.Windows.Forms.FlowLayoutPanel();
            this.p_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_top
            // 
            this.p_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.p_top.Controls.Add(this.lb_serialPortName);
            this.p_top.Controls.Add(this.lb_header_title);
            this.p_top.Controls.Add(this.b_header_cloase);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(1086, 28);
            this.p_top.TabIndex = 4;
            this.p_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseDown);
            this.p_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseMove);
            this.p_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseUp);
            // 
            // lb_serialPortName
            // 
            this.lb_serialPortName.AutoSize = true;
            this.lb_serialPortName.Location = new System.Drawing.Point(83, 2);
            this.lb_serialPortName.Name = "lb_serialPortName";
            this.lb_serialPortName.Size = new System.Drawing.Size(55, 21);
            this.lb_serialPortName.TabIndex = 3;
            this.lb_serialPortName.Text = "label1";
            this.lb_serialPortName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseDown);
            this.lb_serialPortName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseMove);
            this.lb_serialPortName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseUp);
            // 
            // lb_header_title
            // 
            this.lb_header_title.AutoSize = true;
            this.lb_header_title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_header_title.Location = new System.Drawing.Point(3, 2);
            this.lb_header_title.Name = "lb_header_title";
            this.lb_header_title.Size = new System.Drawing.Size(74, 22);
            this.lb_header_title.TabIndex = 0;
            this.lb_header_title.Text = "通訊列表";
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
            this.b_header_cloase.Location = new System.Drawing.Point(1057, -2);
            this.b_header_cloase.Name = "b_header_cloase";
            this.b_header_cloase.Size = new System.Drawing.Size(30, 30);
            this.b_header_cloase.TabIndex = 2;
            this.b_header_cloase.Text = "x";
            this.b_header_cloase.UseVisualStyleBackColor = true;
            this.b_header_cloase.Click += new System.EventHandler(this.b_header_cloase_Click);
            // 
            // t_update
            // 
            this.t_update.Interval = 1;
            this.t_update.Tick += new System.EventHandler(this.t_update_Tick);
            // 
            // fp_board
            // 
            this.fp_board.AutoScroll = true;
            this.fp_board.Location = new System.Drawing.Point(12, 34);
            this.fp_board.Name = "fp_board";
            this.fp_board.Size = new System.Drawing.Size(1062, 422);
            this.fp_board.TabIndex = 5;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1086, 468);
            this.Controls.Add(this.fp_board);
            this.Controls.Add(this.p_top);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.p_top.ResumeLayout(false);
            this.p_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.Label lb_header_title;
        private System.Windows.Forms.Button b_header_cloase;
        private System.Windows.Forms.Label lb_serialPortName;
        private System.Windows.Forms.Timer t_update;
        private System.Windows.Forms.FlowLayoutPanel fp_board;
    }
}