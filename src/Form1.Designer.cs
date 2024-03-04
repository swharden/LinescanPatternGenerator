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
            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            this.nudOscillationCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPointCount = new System.Windows.Forms.NumericUpDown();
            this.nudWidthPercent = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAmplitudePercent = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOscillationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmplitudePercent)).BeginInit();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot1.Location = new System.Drawing.Point(15, 101);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(785, 590);
            this.formsPlot1.TabIndex = 0;
            // 
            // nudOscillationCount
            // 
            this.nudOscillationCount.Location = new System.Drawing.Point(304, 62);
            this.nudOscillationCount.Name = "nudOscillationCount";
            this.nudOscillationCount.Size = new System.Drawing.Size(134, 31);
            this.nudOscillationCount.TabIndex = 1;
            this.nudOscillationCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oscillations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Points";
            // 
            // nudPointCount
            // 
            this.nudPointCount.Location = new System.Drawing.Point(24, 62);
            this.nudPointCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPointCount.Name = "nudPointCount";
            this.nudPointCount.Size = new System.Drawing.Size(134, 31);
            this.nudPointCount.TabIndex = 3;
            this.nudPointCount.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nudWidthPercent
            // 
            this.nudWidthPercent.Location = new System.Drawing.Point(164, 62);
            this.nudWidthPercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidthPercent.Name = "nudWidthPercent";
            this.nudWidthPercent.Size = new System.Drawing.Size(134, 31);
            this.nudWidthPercent.TabIndex = 5;
            this.nudWidthPercent.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width (%)";
            // 
            // nudAmplitudePercent
            // 
            this.nudAmplitudePercent.Location = new System.Drawing.Point(444, 62);
            this.nudAmplitudePercent.Name = "nudAmplitudePercent";
            this.nudAmplitudePercent.Size = new System.Drawing.Size(134, 31);
            this.nudAmplitudePercent.TabIndex = 7;
            this.nudAmplitudePercent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amplitude (%)";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(670, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 705);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAmplitudePercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudWidthPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPointCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudOscillationCount);
            this.Controls.Add(this.formsPlot1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linescan Pattern Generator";
            ((System.ComponentModel.ISupportInitialize)(this.nudOscillationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmplitudePercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
}
