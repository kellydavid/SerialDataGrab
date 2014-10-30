namespace SerialDataGrab
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
            ((System.ComponentModel.ISupportInitialize)(this.baudRateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBitsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Location = new System.Drawing.Point(105, 38);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(121, 21);
            this.comPortComboBox.TabIndex = 0;
            // 
            // comPortLabel
            // 
            this.comPortLabel.AutoSize = true;
            this.comPortLabel.Location = new System.Drawing.Point(28, 41);
            this.comPortLabel.Name = "comPortLabel";
            this.comPortLabel.Size = new System.Drawing.Size(53, 13);
            this.comPortLabel.TabIndex = 1;
            this.comPortLabel.Text = "Com Port:";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(28, 83);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(61, 13);
            this.baudRateLabel.TabIndex = 2;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // baudRateUpDown
            // 
            this.baudRateUpDown.Location = new System.Drawing.Point(106, 76);
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
            this.parityTypeLabel.Location = new System.Drawing.Point(28, 119);
            this.parityTypeLabel.Name = "parityTypeLabel";
            this.parityTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.parityTypeLabel.TabIndex = 4;
            this.parityTypeLabel.Text = "Parity Type:";
            // 
            // parityTypeComboBox
            // 
            this.parityTypeComboBox.FormattingEnabled = true;
            this.parityTypeComboBox.Location = new System.Drawing.Point(105, 116);
            this.parityTypeComboBox.Name = "parityTypeComboBox";
            this.parityTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.parityTypeComboBox.TabIndex = 5;
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Location = new System.Drawing.Point(28, 161);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(53, 13);
            this.dataBitsLabel.TabIndex = 6;
            this.dataBitsLabel.Text = "Data Bits:";
            // 
            // dataBitsUpDown
            // 
            this.dataBitsUpDown.Location = new System.Drawing.Point(105, 159);
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
            this.stopBitsLabel.Location = new System.Drawing.Point(28, 205);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(52, 13);
            this.stopBitsLabel.TabIndex = 8;
            this.stopBitsLabel.Text = "Stop Bits:";
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(104, 197);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.stopBitsComboBox.TabIndex = 9;
            // 
            // handshakeLabel
            // 
            this.handshakeLabel.AutoSize = true;
            this.handshakeLabel.Location = new System.Drawing.Point(28, 236);
            this.handshakeLabel.Name = "handshakeLabel";
            this.handshakeLabel.Size = new System.Drawing.Size(65, 13);
            this.handshakeLabel.TabIndex = 10;
            this.handshakeLabel.Text = "Handshake:";
            // 
            // handshakeComboBox
            // 
            this.handshakeComboBox.FormattingEnabled = true;
            this.handshakeComboBox.Location = new System.Drawing.Point(104, 236);
            this.handshakeComboBox.Name = "handshakeComboBox";
            this.handshakeComboBox.Size = new System.Drawing.Size(121, 21);
            this.handshakeComboBox.TabIndex = 11;
            // 
            // openConnectionButton
            // 
            this.openConnectionButton.Location = new System.Drawing.Point(73, 286);
            this.openConnectionButton.Name = "openConnectionButton";
            this.openConnectionButton.Size = new System.Drawing.Size(98, 23);
            this.openConnectionButton.TabIndex = 12;
            this.openConnectionButton.Text = "Open Connection";
            this.openConnectionButton.UseVisualStyleBackColor = true;
            this.openConnectionButton.Click += new System.EventHandler(this.openConnectionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 321);
            this.Controls.Add(this.openConnectionButton);
            this.Controls.Add(this.handshakeComboBox);
            this.Controls.Add(this.handshakeLabel);
            this.Controls.Add(this.stopBitsComboBox);
            this.Controls.Add(this.stopBitsLabel);
            this.Controls.Add(this.dataBitsUpDown);
            this.Controls.Add(this.dataBitsLabel);
            this.Controls.Add(this.parityTypeComboBox);
            this.Controls.Add(this.parityTypeLabel);
            this.Controls.Add(this.baudRateUpDown);
            this.Controls.Add(this.baudRateLabel);
            this.Controls.Add(this.comPortLabel);
            this.Controls.Add(this.comPortComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.baudRateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBitsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

