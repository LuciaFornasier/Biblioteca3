using System.ComponentModel;

namespace BIbliotecaForm;

partial class Bibliotecaf
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(66, 295);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(284, 64);
        button1.TabIndex = 0;
        button1.Text = "libri";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(469, 293);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(265, 66);
        button2.TabIndex = 1;
        button2.Text = "Autori";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)178));
        label1.Location = new System.Drawing.Point(194, 83);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(385, 90);
        label1.TabIndex = 2;
        label1.Text = "Biblioteca";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Biblioteca
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "Biblioteca";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;

    #endregion
}