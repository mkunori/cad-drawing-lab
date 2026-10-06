namespace CadDrawingLab
{
    partial class MainForm
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
            WidthLabel = new Label();
            HeightLabel = new Label();
            WidthNumericUpDown = new NumericUpDown();
            HeightNumericUpDown = new NumericUpDown();
            ExportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)WidthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeightNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(28, 113);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(50, 15);
            WidthLabel.TabIndex = 0;
            WidthLabel.Text = "幅 (mm)";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(28, 167);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(58, 15);
            HeightLabel.TabIndex = 1;
            HeightLabel.Text = "高さ (mm)";
            // 
            // WidthNumericUpDown
            // 
            WidthNumericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            WidthNumericUpDown.Location = new Point(170, 111);
            WidthNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            WidthNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WidthNumericUpDown.Name = "WidthNumericUpDown";
            WidthNumericUpDown.Size = new Size(120, 23);
            WidthNumericUpDown.TabIndex = 2;
            WidthNumericUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // HeightNumericUpDown
            // 
            HeightNumericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            HeightNumericUpDown.Location = new Point(170, 167);
            HeightNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            HeightNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            HeightNumericUpDown.Name = "HeightNumericUpDown";
            HeightNumericUpDown.Size = new Size(120, 23);
            HeightNumericUpDown.TabIndex = 3;
            HeightNumericUpDown.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(28, 262);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(262, 23);
            ExportButton.TabIndex = 4;
            ExportButton.Text = "DWGを作成して表示";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 371);
            Controls.Add(ExportButton);
            Controls.Add(HeightNumericUpDown);
            Controls.Add(WidthNumericUpDown);
            Controls.Add(HeightLabel);
            Controls.Add(WidthLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CAD Drawing Lab";
            ((System.ComponentModel.ISupportInitialize)WidthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeightNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WidthLabel;
        private Label HeightLabel;
        private NumericUpDown WidthNumericUpDown;
        private NumericUpDown HeightNumericUpDown;
        private Button ExportButton;
    }
}
