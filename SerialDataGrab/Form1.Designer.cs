namespace SerialDataGrab
{
    partial class SerialDataGrab
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
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.comPortLabel = new System.Windows.Forms.Label();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.baudRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.parityTypeLabel = new System.Windows.Forms.Label();
            this.parityTypeComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.dataBitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.handshakeLabel = new System.Windows.Forms.Label();
            this.handshakeComboBox = new System.Windows.Forms.ComboBox();
            this.openConnectionButton = new System.Windows.Forms.Button();
            this.serialConGroupBox = new System.Windows.Forms.GroupBox();
            this.logFileGroupBox = new System.Windows.Forms.GroupBox();
            this.selectFileLocationButton = new System.Windows.Forms.Button();
            this.saveLocationLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.baudRateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBitsUpDown)).BeginInit();
            this.serialConGroupBox.SuspendLayout();
            this.logFileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Location = new System.Drawing.Point(97, 25);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(121, 21);
            this.comPortComboBox.TabIndex = 0;
            // 
            // comPortLabel
            // 
            this.comPortLabel.AutoSize = true;
            this.comPortLabel.Location = new System.Drawing.Point(20, 28);
            this.comPortLabel.Name = "comPortLabel";
            this.comPortLabel.Size = new System.Drawing.Size(53, 13);
            this.comPortLabel.TabIndex = 1;
            this.comPortLabel.Text = "Com Port:";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(20, 70);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(61, 13);
            this.baudRateLabel.TabIndex = 2;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // baudRateUpDown
            // 
            this.baudRateUpDown.Location = new System.Drawing.Point(98, 63);
            this.baudRateUpDown.Maximum = new decimal(new int[] {
            115200,
            0,
            0,
            0});
            this.baudRateUpDown.Name = "baudRateUpDown";
            this.baudRateUpDown.Size = new System.Drawing.Size(120, 20);
            this.baudRateUpDown.TabIndex = 3;
            // 
            // parityTypeLabel
            // 
            this.parityTypeLabel.AutoSize = true;
            this.parityTypeLabel.Location = new System.Drawing.Point(20, 106);
            this.parityTypeLabel.Name = "parityTypeLabel";
            this.parityTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.parityTypeLabel.TabIndex = 4;
            this.parityTypeLabel.Text = "Parity Type:";
            // 
            // parityTypeComboBox
            // 
            this.parityTypeComboBox.FormattingEnabled = true;
            this.parityTypeComboBox.Location = new System.Drawing.Point(97, 103);
            this.parityTypeComboBox.Name = "parityTypeComboBox";
            this.parityTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.parityTypeComboBox.TabIndex = 5;
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Location = new System.Drawing.Point(20, 148);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(53, 13);
            this.dataBitsLabel.TabIndex = 6;
            this.dataBitsLabel.Text = "Data Bits:";
            // 
            // dataBitsUpDown
            // 
            this.dataBitsUpDown.Location = new System.Drawing.Point(97, 146);
            this.dataBitsUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.dataBitsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dataBitsUpDown.Name = "dataBitsUpDown";
            this.dataBitsUpDown.Size = new System.Drawing.Size(120, 20);
            this.dataBitsUpDown.TabIndex = 7;
            this.dataBitsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Location = new System.Drawing.Point(20, 192);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(52, 13);
            this.stopBitsLabel.TabIndex = 8;
            this.stopBitsLabel.Text = "Stop Bits:";
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(96, 184);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.stopBitsComboBox.TabIndex = 9;
            // 
            // handshakeLabel
            // 
            this.handshakeLabel.AutoSize = true;
            this.handshakeLabel.Location = new System.Drawing.Point(20, 223);
            this.handshakeLabel.Name = "handshakeLabel";
            this.handshakeLabel.Size = new System.Drawing.Size(65, 13);
            this.handshakeLabel.TabIndex = 10;
            this.handshakeLabel.Text = "Handshake:";
            // 
            // handshakeComboBox
            // 
            this.handshakeComboBox.FormattingEnabled = true;
            this.handshakeComboBox.Location = new System.Drawing.Point(96, 223);
            this.handshakeComboBox.Name = "handshakeComboBox";
            this.handshakeComboBox.Size = new System.Drawing.Size(121, 21);
            this.handshakeComboBox.TabIndex = 11;
            // 
            // openConnectionButton
            // 
            this.openConnectionButton.Location = new System.Drawing.Point(58, 259);
            this.openConnectionButton.Name = "openConnectionButton";
            this.openConnectionButton.Size = new System.Drawing.Size(98, 23);
            this.openConnectionButton.TabIndex = 12;
            this.openConnectionButton.Text = "Open Connection";
            this.openConnectionButton.UseVisualStyleBackColor = true;
            this.openConnectionButton.Click += new System.EventHandler(this.openConnectionButton_Click);
            // 
            // serialConGroupBox
            // 
            this.serialConGroupBox.Controls.Add(this.comPortLabel);
            this.serialConGroupBox.Controls.Add(this.openConnectionButton);
            this.serialConGroupBox.Controls.Add(this.comPortComboBox);
            this.serialConGroupBox.Controls.Add(this.handshakeComboBox);
            this.serialConGroupBox.Controls.Add(this.baudRateLabel);
            this.serialConGroupBox.Controls.Add(this.handshakeLabel);
            this.serialConGroupBox.Controls.Add(this.baudRateUpDown);
            this.serialConGroupBox.Controls.Add(this.stopBitsComboBox);
            this.serialConGroupBox.Controls.Add(this.parityTypeLabel);
            this.serialConGroupBox.Controls.Add(this.stopBitsLabel);
            this.serialConGroupBox.Controls.Add(this.parityTypeComboBox);
            this.serialConGroupBox.Controls.Add(this.dataBitsUpDown);
            this.serialConGroupBox.Controls.Add(this.dataBitsLabel);
            this.serialConGroupBox.Location = new System.Drawing.Point(12, 12);
            this.serialConGroupBox.Name = "serialConGroupBox";
            this.serialConGroupBox.Size = new System.Drawing.Size(228, 297);
            this.serialConGroupBox.TabIndex = 13;
            this.serialConGroupBox.TabStop = false;
            this.serialConGroupBox.Text = "Serial Connection";
            // 
            // logFileGroupBox
            // 
            this.logFileGroupBox.Controls.Add(this.saveLocationLabel);
            this.logFileGroupBox.Controls.Add(this.selectFileLocationButton);
            this.logFileGroupBox.Location = new System.Drawing.Point(273, 12);
            this.logFileGroupBox.Name = "logFileGroupBox";
            this.logFileGroupBox.Size = new System.Drawing.Size(329, 166);
            this.logFileGroupBox.TabIndex = 14;
            this.logFileGroupBox.TabStop = false;
            this.logFileGroupBox.Text = "Log File";
            // 
            // selectFileLocationButton
            // 
            this.selectFileLocationButton.Location = new System.Drawing.Point(52, 28);
            this.selectFileLocationButton.Name = "selectFileLocationButton";
            this.selectFileLocationButton.Size = new System.Drawing.Size(143, 23);
            this.selectFileLocationButton.TabIndex = 0;
            this.selectFileLocationButton.Text = "Select File Location";
            this.selectFileLocationButton.UseVisualStyleBackColor = true;
            this.selectFileLocationButton.Click += new System.EventHandler(this.selectFileLocationButton_Click);
            // 
            // saveLocationLabel
            // 
            this.saveLocationLabel.AutoSize = true;
            this.saveLocationLabel.Location = new System.Drawing.Point(6, 70);
            this.saveLocationLabel.Name = "saveLocationLabel";
            this.saveLocationLabel.Size = new System.Drawing.Size(82, 13);
            this.saveLocationLabel.TabIndex = 1;
            this.saveLocationLabel.Text = "Save Location: ";
            // 
            // SerialDataGrab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 317);
            this.Controls.Add(this.logFileGroupBox);
            this.Controls.Add(this.serialConGroupBox);
            this.Name = "SerialDataGrab";
            this.Text = "Serial Data Grab";
            ((System.ComponentModel.ISupportInitialize)(this.baudRateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBitsUpDown)).EndInit();
            this.serialConGroupBox.ResumeLayout(false);
            this.serialConGroupBox.PerformLayout();
            this.logFileGroupBox.ResumeLayout(false);
            this.logFileGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.Label comPortLabel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.NumericUpDown baudRateUpDown;
        private System.Windows.Forms.Label parityTypeLabel;
        private System.Windows.Forms.ComboBox parityTypeComboBox;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.NumericUpDown dataBitsUpDown;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.Label handshakeLabel;
        private System.Windows.Forms.ComboBox handshakeComboBox;
        private System.Windows.Forms.Button openConnectionButton;
        private System.Windows.Forms.GroupBox serialConGroupBox;
        private System.Windows.Forms.GroupBox logFileGroupBox;
        private System.Windows.Forms.Label saveLocationLabel;
        private System.Windows.Forms.Button selectFileLocationButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

