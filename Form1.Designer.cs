namespace CadDrawingLab
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
            widthLabel = new Label();
            heightLabel = new Label();
            widthNumericUpDown = new NumericUpDown();
            heightNumericUpDown = new NumericUpDown();
            exportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(28, 113);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(50, 15);
            widthLabel.TabIndex = 0;
            widthLabel.Text = "幅 (mm)";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(28, 167);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(58, 15);
            heightLabel.TabIndex = 1;
            heightLabel.Text = "高さ (mm)";
            // 
            // widthNumericUpDown
            // 
            widthNumericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            widthNumericUpDown.Location = new Point(170, 111);
            widthNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            widthNumericUpDown.Name = "widthNumericUpDown";
            widthNumericUpDown.Size = new Size(120, 23);
            widthNumericUpDown.TabIndex = 2;
            widthNumericUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // heightNumericUpDown
            // 
            heightNumericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            heightNumericUpDown.Location = new Point(170, 167);
            heightNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            heightNumericUpDown.Name = "heightNumericUpDown";
            heightNumericUpDown.Size = new Size(120, 23);
            heightNumericUpDown.TabIndex = 3;
            heightNumericUpDown.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // exportButton
            // 
            exportButton.Location = new Point(28, 262);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(262, 23);
            exportButton.TabIndex = 4;
            exportButton.Text = "DWGを作成して表示";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 371);
            Controls.Add(exportButton);
            Controls.Add(heightNumericUpDown);
            Controls.Add(widthNumericUpDown);
            Controls.Add(heightLabel);
            Controls.Add(widthLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CAD Drawing Lab";
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label widthLabel;
        private Label heightLabel;
        private NumericUpDown widthNumericUpDown;
        private NumericUpDown heightNumericUpDown;
        private Button exportButton;
    }
}
