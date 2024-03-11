namespace LinescanPatternGenerator;

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
        formsPlot1 = new ScottPlot.WinForms.FormsPlot();
        nudOscillationCount = new NumericUpDown();
        label1 = new Label();
        label2 = new Label();
        nudPointCount = new NumericUpDown();
        nudWidthPercent = new NumericUpDown();
        label3 = new Label();
        nudAmplitudePercent = new NumericUpDown();
        label4 = new Label();
        button1 = new Button();
        nudRotation = new NumericUpDown();
        label5 = new Label();
        cbPattern = new ComboBox();
        label6 = new Label();
        lblPoints = new Label();
        ((System.ComponentModel.ISupportInitialize)nudOscillationCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudPointCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudWidthPercent).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudAmplitudePercent).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudRotation).BeginInit();
        SuspendLayout();
        // 
        // formsPlot1
        // 
        formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        formsPlot1.DisplayScale = 1.5F;
        formsPlot1.Location = new Point(10, 61);
        formsPlot1.Margin = new Padding(4, 3, 4, 3);
        formsPlot1.Name = "formsPlot1";
        formsPlot1.Size = new Size(791, 708);
        formsPlot1.TabIndex = 0;
        // 
        // nudOscillationCount
        // 
        nudOscillationCount.Location = new Point(289, 32);
        nudOscillationCount.Margin = new Padding(2);
        nudOscillationCount.Name = "nudOscillationCount";
        nudOscillationCount.Size = new Size(94, 23);
        nudOscillationCount.TabIndex = 1;
        nudOscillationCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(289, 15);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(48, 15);
        label1.TabIndex = 2;
        label1.Text = "Repeats";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(191, 15);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(40, 15);
        label2.TabIndex = 4;
        label2.Text = "Points";
        // 
        // nudPointCount
        // 
        nudPointCount.Location = new Point(191, 32);
        nudPointCount.Margin = new Padding(2);
        nudPointCount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        nudPointCount.Name = "nudPointCount";
        nudPointCount.Size = new Size(94, 23);
        nudPointCount.TabIndex = 3;
        nudPointCount.Value = new decimal(new int[] { 200, 0, 0, 0 });
        // 
        // nudWidthPercent
        // 
        nudWidthPercent.Location = new Point(387, 32);
        nudWidthPercent.Margin = new Padding(2);
        nudWidthPercent.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudWidthPercent.Name = "nudWidthPercent";
        nudWidthPercent.Size = new Size(94, 23);
        nudWidthPercent.TabIndex = 5;
        nudWidthPercent.Value = new decimal(new int[] { 80, 0, 0, 0 });
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(387, 15);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(60, 15);
        label3.TabIndex = 6;
        label3.Text = "Width (%)";
        // 
        // nudAmplitudePercent
        // 
        nudAmplitudePercent.Location = new Point(485, 32);
        nudAmplitudePercent.Margin = new Padding(2);
        nudAmplitudePercent.Name = "nudAmplitudePercent";
        nudAmplitudePercent.Size = new Size(94, 23);
        nudAmplitudePercent.TabIndex = 7;
        nudAmplitudePercent.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(485, 15);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(64, 15);
        label4.TabIndex = 8;
        label4.Text = "Height (%)";
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        button1.Location = new Point(723, 11);
        button1.Margin = new Padding(2);
        button1.Name = "button1";
        button1.Size = new Size(78, 45);
        button1.TabIndex = 9;
        button1.Text = "Save";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // nudRotation
        // 
        nudRotation.Increment = new decimal(new int[] { 5, 0, 0, 0 });
        nudRotation.Location = new Point(583, 32);
        nudRotation.Margin = new Padding(2);
        nudRotation.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
        nudRotation.Name = "nudRotation";
        nudRotation.Size = new Size(94, 23);
        nudRotation.TabIndex = 10;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(583, 15);
        label5.Margin = new Padding(2, 0, 2, 0);
        label5.Name = "label5";
        label5.Size = new Size(83, 15);
        label5.TabIndex = 11;
        label5.Text = "Rotation (deg)";
        // 
        // cbPattern
        // 
        cbPattern.DropDownStyle = ComboBoxStyle.DropDownList;
        cbPattern.FormattingEnabled = true;
        cbPattern.Location = new Point(10, 32);
        cbPattern.Name = "cbPattern";
        cbPattern.Size = new Size(176, 23);
        cbPattern.TabIndex = 12;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(10, 14);
        label6.Margin = new Padding(2, 0, 2, 0);
        label6.Name = "label6";
        label6.Size = new Size(45, 15);
        label6.TabIndex = 13;
        label6.Text = "Pattern";
        // 
        // lblPoints
        // 
        lblPoints.AutoSize = true;
        lblPoints.ForeColor = SystemColors.ButtonShadow;
        lblPoints.Location = new Point(191, 57);
        lblPoints.Name = "lblPoints";
        lblPoints.Size = new Size(38, 15);
        lblPoints.TabIndex = 14;
        lblPoints.Text = "label7";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(812, 777);
        Controls.Add(lblPoints);
        Controls.Add(label6);
        Controls.Add(cbPattern);
        Controls.Add(label5);
        Controls.Add(nudRotation);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(nudAmplitudePercent);
        Controls.Add(label3);
        Controls.Add(nudWidthPercent);
        Controls.Add(label2);
        Controls.Add(nudPointCount);
        Controls.Add(label1);
        Controls.Add(nudOscillationCount);
        Controls.Add(formsPlot1);
        Margin = new Padding(2);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Linescan Pattern Generator";
        ((System.ComponentModel.ISupportInitialize)nudOscillationCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudPointCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudWidthPercent).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudAmplitudePercent).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudRotation).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ScottPlot.WinForms.FormsPlot formsPlot1;
    private NumericUpDown nudOscillationCount;
    private Label label1;
    private Label label2;
    private NumericUpDown nudPointCount;
    private NumericUpDown nudWidthPercent;
    private Label label3;
    private NumericUpDown nudAmplitudePercent;
    private Label label4;
    private Button button1;
    private NumericUpDown nudRotation;
    private Label label5;
    private ComboBox cbPattern;
    private Label label6;
    private Label lblPoints;
}
