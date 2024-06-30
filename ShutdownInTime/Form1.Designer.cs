namespace ShutdownInTime
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RemainingLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.minuteNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.hourNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.forceShutdownButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.countDownPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.countDownPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemainingLabel
            // 
            this.RemainingLabel.AutoSize = true;
            this.RemainingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingLabel.Location = new System.Drawing.Point(0, 0);
            this.RemainingLabel.Name = "RemainingLabel";
            this.RemainingLabel.Size = new System.Drawing.Size(105, 55);
            this.RemainingLabel.TabIndex = 6;
            this.RemainingLabel.Text = "000";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(297, 10);
            this.progressBar1.TabIndex = 7;
            // 
            // minuteNumeric
            // 
            this.minuteNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteNumeric.Location = new System.Drawing.Point(199, 6);
            this.minuteNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minuteNumeric.Name = "minuteNumeric";
            this.minuteNumeric.Size = new System.Drawing.Size(45, 29);
            this.minuteNumeric.TabIndex = 9;
            this.minuteNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minuteNumeric.ValueChanged += new System.EventHandler(this.minuteNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "hours";
            // 
            // hourNumeric
            // 
            this.hourNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourNumeric.Location = new System.Drawing.Point(96, 6);
            this.hourNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.hourNumeric.Name = "hourNumeric";
            this.hourNumeric.Size = new System.Drawing.Size(54, 29);
            this.hourNumeric.TabIndex = 12;
            this.hourNumeric.ValueChanged += new System.EventHandler(this.hourNumeric_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Shutdown in...";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.forceShutdownButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.minuteNumeric);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hourNumeric);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 86);
            this.panel1.TabIndex = 16;
            // 
            // forceShutdownButton
            // 
            this.forceShutdownButton.BackColor = System.Drawing.Color.Brown;
            this.forceShutdownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forceShutdownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forceShutdownButton.Image = global::SIT.Properties.Resources.shutdown_24;
            this.forceShutdownButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forceShutdownButton.Location = new System.Drawing.Point(1, 46);
            this.forceShutdownButton.Name = "forceShutdownButton";
            this.forceShutdownButton.Size = new System.Drawing.Size(300, 37);
            this.forceShutdownButton.TabIndex = 8;
            this.forceShutdownButton.Text = "Force Shutdown Now";
            this.forceShutdownButton.UseVisualStyleBackColor = false;
            this.forceShutdownButton.Click += new System.EventHandler(this.forceShutdownButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StartButton);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 57);
            this.panel2.TabIndex = 18;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.OliveDrab;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Image = global::SIT.Properties.Resources.timer_24;
            this.StartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartButton.Location = new System.Drawing.Point(0, 16);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(300, 37);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.countDownPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(316, 158);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // countDownPanel
            // 
            this.countDownPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.countDownPanel.Controls.Add(this.label4);
            this.countDownPanel.Controls.Add(this.RemainingLabel);
            this.countDownPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.countDownPanel.Location = new System.Drawing.Point(3, 158);
            this.countDownPanel.Name = "countDownPanel";
            this.countDownPanel.Size = new System.Drawing.Size(302, 100);
            this.countDownPanel.TabIndex = 20;
            this.countDownPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "seconds remaining";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(329, 164);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "BazWare SIT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.countDownPanel.ResumeLayout(false);
            this.countDownPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label RemainingLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown minuteNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hourNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel countDownPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button forceShutdownButton;
    }
}

