namespace Project_GUICurrencyConverter
{
    partial class ConversionForm
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
            numericUpDownAmount = new NumericUpDown();
            currency = new Label();
            resultLable = new Label();
            resultButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.DecimalPlaces = 2;
            numericUpDownAmount.Location = new Point(94, 134);
            numericUpDownAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownAmount.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(172, 23);
            numericUpDownAmount.TabIndex = 0;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // currency
            // 
            currency.AutoSize = true;
            currency.Location = new Point(423, 142);
            currency.Name = "currency";
            currency.Size = new Size(69, 15);
            currency.TabIndex = 1;
            currency.Text = "BGN to EUR";
            // 
            // resultLable
            // 
            resultLable.BackColor = Color.Chartreuse;
            resultLable.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            resultLable.Location = new Point(147, 229);
            resultLable.Name = "resultLable";
            resultLable.Size = new Size(423, 51);
            resultLable.TabIndex = 2;
            // 
            // resultButton
            // 
            resultButton.Location = new Point(314, 138);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(75, 23);
            resultButton.TabIndex = 3;
            resultButton.Text = "Convert";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += ConvertCurrency;
            // 
            // ConversionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultButton);
            Controls.Add(resultLable);
            Controls.Add(currency);
            Controls.Add(numericUpDownAmount);
            Name = "ConversionForm";
            Text = "CurrencyConverter";
            Load += ConversionForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownAmount;
        private Label currency;
        private Label resultLable;
        private Button resultButton;
    }
}