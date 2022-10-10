namespace TrackbarTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelColor = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.trackBarBlue = new Guna.UI2.WinForms.Guna2TrackBar();
            this.trackBarRed = new Guna.UI2.WinForms.Guna2TrackBar();
            this.trackBarGreen = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelColor.Location = new System.Drawing.Point(0, 0);
            this.panelColor.Margin = new System.Windows.Forms.Padding(0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(800, 217);
            this.panelColor.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.375F));
            this.tableLayoutPanel1.Controls.Add(this.lblBlue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGreen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBarBlue, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.trackBarRed, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBarGreen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRed, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 217);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 121);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBlue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBlue.Location = new System.Drawing.Point(696, 80);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(101, 41);
            this.lblBlue.TabIndex = 10;
            this.lblBlue.Text = "Blue";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGreen.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGreen.Location = new System.Drawing.Point(696, 40);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(101, 40);
            this.lblGreen.TabIndex = 9;
            this.lblGreen.Text = "Green";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarBlue.FillColor = System.Drawing.Color.Silver;
            this.trackBarBlue.Location = new System.Drawing.Point(3, 83);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(687, 35);
            this.trackBarBlue.TabIndex = 6;
            this.trackBarBlue.ThumbColor = System.Drawing.Color.RoyalBlue;
            this.trackBarBlue.Value = 0;
            this.trackBarBlue.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarRed.FillColor = System.Drawing.Color.Silver;
            this.trackBarRed.Location = new System.Drawing.Point(3, 3);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(687, 34);
            this.trackBarRed.TabIndex = 2;
            this.trackBarRed.ThumbColor = System.Drawing.Color.Red;
            this.trackBarRed.Value = 0;
            this.trackBarRed.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarGreen.FillColor = System.Drawing.Color.Silver;
            this.trackBarGreen.Location = new System.Drawing.Point(3, 43);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(687, 34);
            this.trackBarGreen.TabIndex = 7;
            this.trackBarGreen.ThumbColor = System.Drawing.Color.Green;
            this.trackBarGreen.Value = 0;
            this.trackBarGreen.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRed.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRed.Location = new System.Drawing.Point(696, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(101, 40);
            this.lblRed.TabIndex = 8;
            this.lblRed.Text = "Red";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelColor;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblBlue;
        private Label lblGreen;
        private Guna.UI2.WinForms.Guna2TrackBar trackBarBlue;
        private Guna.UI2.WinForms.Guna2TrackBar trackBarRed;
        private Guna.UI2.WinForms.Guna2TrackBar trackBarGreen;
        private Label lblRed;
    }
}