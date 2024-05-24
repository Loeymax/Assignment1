namespace ConvertingApp
{
    public partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.kgToGramsRadioButton = new System.Windows.Forms.RadioButton();
            this.gramsToKgRadioButton = new System.Windows.Forms.RadioButton();
            this.cmToMetersRadioButton = new System.Windows.Forms.RadioButton();
            this.metersToCmRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(200, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(12, 149);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(200, 23);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 185);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Result";
            // 
            // kgToGramsRadioButton
            // 
            this.kgToGramsRadioButton.AutoSize = true;
            this.kgToGramsRadioButton.Location = new System.Drawing.Point(12, 38);
            this.kgToGramsRadioButton.Name = "kgToGramsRadioButton";
            this.kgToGramsRadioButton.Size = new System.Drawing.Size(95, 17);
            this.kgToGramsRadioButton.TabIndex = 3;
            this.kgToGramsRadioButton.TabStop = true;
            this.kgToGramsRadioButton.Text = "Kg to Grams";
            this.kgToGramsRadioButton.UseVisualStyleBackColor = true;
            // 
            // gramsToKgRadioButton
            // 
            this.gramsToKgRadioButton.AutoSize = true;
            this.gramsToKgRadioButton.Location = new System.Drawing.Point(12, 61);
            this.gramsToKgRadioButton.Name = "gramsToKgRadioButton";
            this.gramsToKgRadioButton.Size = new System.Drawing.Size(95, 17);
            this.gramsToKgRadioButton.TabIndex = 4;
            this.gramsToKgRadioButton.TabStop = true;
            this.gramsToKgRadioButton.Text = "Grams to Kg";
            this.gramsToKgRadioButton.UseVisualStyleBackColor = true;
            // 
            // cmToMetersRadioButton
            // 
            this.cmToMetersRadioButton.AutoSize = true;
            this.cmToMetersRadioButton.Location = new System.Drawing.Point(12, 84);
            this.cmToMetersRadioButton.Name = "cmToMetersRadioButton";
            this.cmToMetersRadioButton.Size = new System.Drawing.Size(95, 17);
            this.cmToMetersRadioButton.TabIndex = 5;
            this.cmToMetersRadioButton.TabStop = true;
            this.cmToMetersRadioButton.Text = "Cm to Meters";
            this.cmToMetersRadioButton.UseVisualStyleBackColor = true;
            // 
            // metersToCmRadioButton
            // 
            this.metersToCmRadioButton.AutoSize = true;
            this.metersToCmRadioButton.Location = new System.Drawing.Point(12, 107);
            this.metersToCmRadioButton.Name = "metersToCmRadioButton";
            this.metersToCmRadioButton.Size = new System.Drawing.Size(95, 17);
            this.metersToCmRadioButton.TabIndex = 6;
            this.metersToCmRadioButton.TabStop = true;
            this.metersToCmRadioButton.Text = "Meters to Cm";
            this.metersToCmRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 211);
            this.Controls.Add(this.metersToCmRadioButton);
            this.Controls.Add(this.cmToMetersRadioButton);
            this.Controls.Add(this.gramsToKgRadioButton);
            this.Controls.Add(this.kgToGramsRadioButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RadioButton kgToGramsRadioButton;
        private System.Windows.Forms.RadioButton gramsToKgRadioButton;
        private System.Windows.Forms.RadioButton cmToMetersRadioButton;
        private System.Windows.Forms.RadioButton metersToCmRadioButton;
    }
}