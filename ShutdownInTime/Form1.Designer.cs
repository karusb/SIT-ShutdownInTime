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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.DKradio = new System.Windows.Forms.RadioButton();
            this.SaatRadio = new System.Windows.Forms.RadioButton();
            this.SaatDKradio = new System.Windows.Forms.RadioButton();
            this.RemainingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(30, 102);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(180, 102);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(90, 62);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(100, 20);
            this.InputBox.TabIndex = 2;
            // 
            // DKradio
            // 
            this.DKradio.AutoSize = true;
            this.DKradio.Location = new System.Drawing.Point(30, 29);
            this.DKradio.Name = "DKradio";
            this.DKradio.Size = new System.Drawing.Size(59, 17);
            this.DKradio.TabIndex = 3;
            this.DKradio.TabStop = true;
            this.DKradio.Text = "Dakika";
            this.DKradio.UseVisualStyleBackColor = true;
            this.DKradio.CheckedChanged += new System.EventHandler(this.DKradio_CheckedChanged);
            // 
            // SaatRadio
            // 
            this.SaatRadio.AutoSize = true;
            this.SaatRadio.Location = new System.Drawing.Point(121, 29);
            this.SaatRadio.Name = "SaatRadio";
            this.SaatRadio.Size = new System.Drawing.Size(47, 17);
            this.SaatRadio.TabIndex = 4;
            this.SaatRadio.TabStop = true;
            this.SaatRadio.Text = "Saat";
            this.SaatRadio.UseVisualStyleBackColor = true;
            this.SaatRadio.CheckedChanged += new System.EventHandler(this.SaatRadio_CheckedChanged);
            // 
            // SaatDKradio
            // 
            this.SaatDKradio.AutoSize = true;
            this.SaatDKradio.Location = new System.Drawing.Point(212, 29);
            this.SaatDKradio.Name = "SaatDKradio";
            this.SaatDKradio.Size = new System.Drawing.Size(84, 17);
            this.SaatDKradio.TabIndex = 5;
            this.SaatDKradio.TabStop = true;
            this.SaatDKradio.Text = "Saat:Dakika";
            this.SaatDKradio.UseVisualStyleBackColor = true;
            this.SaatDKradio.CheckedChanged += new System.EventHandler(this.SaatDKradio_CheckedChanged);
            // 
            // RemainingLabel
            // 
            this.RemainingLabel.AutoSize = true;
            this.RemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingLabel.Location = new System.Drawing.Point(12, 128);
            this.RemainingLabel.Name = "RemainingLabel";
            this.RemainingLabel.Size = new System.Drawing.Size(212, 73);
            this.RemainingLabel.TabIndex = 6;
            this.RemainingLabel.Text = "00000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(314, 207);
            this.Controls.Add(this.RemainingLabel);
            this.Controls.Add(this.SaatDKradio);
            this.Controls.Add(this.SaatRadio);
            this.Controls.Add(this.DKradio);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Doğru Zamanda PC\'yi Kapat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.RadioButton DKradio;
        private System.Windows.Forms.RadioButton SaatRadio;
        private System.Windows.Forms.RadioButton SaatDKradio;
        private System.Windows.Forms.Label RemainingLabel;
    }
}

