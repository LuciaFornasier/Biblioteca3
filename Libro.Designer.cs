namespace Biblioteca;

partial class Libro
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new System.Windows.Forms.Button();
        groupBox1 = new System.Windows.Forms.GroupBox();
        textBox3 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        textBox5 = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        textBox4 = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox1 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(161, 306);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(298, 47);
        button1.TabIndex = 0;
        button1.Text = "Invia";
        button1.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(textBox3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(textBox5);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(textBox4);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(textBox2);
        groupBox1.Controls.Add(textBox1);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(button1);
        groupBox1.Location = new System.Drawing.Point(48, 47);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(632, 375);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(261, 223);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(270, 27);
        textBox3.TabIndex = 12;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(42, 225);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(125, 34);
        label2.TabIndex = 11;
        label2.Text = "Pagine";
        // 
        // textBox5
        // 
        textBox5.Location = new System.Drawing.Point(261, 182);
        textBox5.Name = "textBox5";
        textBox5.Size = new System.Drawing.Size(270, 27);
        textBox5.TabIndex = 10;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(42, 175);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(125, 34);
        label5.TabIndex = 9;
        label5.Text = "Prezzo";
        // 
        // textBox4
        // 
        textBox4.Location = new System.Drawing.Point(261, 104);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(270, 27);
        textBox4.TabIndex = 8;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(42, 97);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(125, 34);
        label4.TabIndex = 7;
        label4.Text = "Autore";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(42, 131);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(125, 34);
        label3.TabIndex = 5;
        label3.Text = "Data di nascita";
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(261, 138);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(270, 27);
        textBox2.TabIndex = 4;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(261, 70);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(270, 27);
        textBox1.TabIndex = 2;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(42, 63);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(125, 34);
        label1.TabIndex = 1;
        label1.Text = "Titolo";
        label1.Click += label1_Click;
        // 
        // Libro
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(groupBox1);
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;

    #endregion
}