﻿namespace ConvertUtilityForm;

partial class LoadingForm
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
        progressBar1 = new ProgressBar();
        label1 = new Label();
        label2 = new Label();
        SuspendLayout();

        progressBar1.Location = new Point(7, 29);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(162, 23);
        progressBar1.TabIndex = 0;

        label1.AutoSize = true;
        label1.Location = new Point(7, 9);
        label1.Name = "label1";
        label1.Size = new Size(78, 15);
        label1.TabIndex = 1;
        label1.Text = "Конвертация";

        label2.AutoSize = true;
        label2.Location = new Point(91, 9);
        label2.Name = "label2";
        label2.Size = new Size(0, 15);
        label2.TabIndex = 2;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(177, 64);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(progressBar1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        StartPosition = FormStartPosition.CenterScreen;
        Name = "LoadingForm";
        ResumeLayout(false);
        PerformLayout();
    }
    private ProgressBar progressBar1;
    private Label label1;
    private Label label2;
    
    #endregion
}
