using System.ComponentModel;

namespace Biblioteca;

partial class Autore
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
        label1 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        textBox4 = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        groupBox1 = new System.Windows.Forms.GroupBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(24, 34);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(179, 39);
        label1.TabIndex = 0;
        label1.Text = "Nome";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(274, 25);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(337, 27);
        textBox1.TabIndex = 1;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(274, 64);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(337, 27);
        textBox2.TabIndex = 3;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(24, 73);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(179, 39);
        label2.TabIndex = 2;
        label2.Text = "Cognome";
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(274, 103);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(337, 27);
        textBox3.TabIndex = 5;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(24, 112);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(179, 39);
        label3.TabIndex = 4;
        label3.Text = "Data di nascita";
        // 
        // textBox4
        // 
        textBox4.Location = new System.Drawing.Point(274, 142);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(337, 27);
        textBox4.TabIndex = 7;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(24, 151);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(179, 39);
        label4.TabIndex = 6;
        label4.Text = "Libri";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(207, 294);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(241, 52);
        button1.TabIndex = 10;
        button1.Text = "Invia\r\n";
        button1.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(button1);
        groupBox1.Controls.Add(textBox4);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(textBox3);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(textBox2);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(textBox1);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new System.Drawing.Point(50, 58);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(691, 365);
        groupBox1.TabIndex = 11;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // Autore
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(groupBox1);
        Text = "Autore";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}