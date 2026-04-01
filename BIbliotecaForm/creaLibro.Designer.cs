using System.ComponentModel;

namespace BIbliotecaForm;

partial class creaLibro
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        textBox4 = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(258, 386);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(293, 46);
        button1.TabIndex = 0;
        button1.Text = "Crea";
        button1.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Arial Narrow", 28.2F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(270, 26);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(294, 55);
        label1.TabIndex = 1;
        label1.Text = "Libro";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(25, 120);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(232, 47);
        label2.TabIndex = 2;
        label2.Text = "Titolo";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(25, 172);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(232, 47);
        label3.TabIndex = 3;
        label3.Text = "Autore";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(25, 219);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(232, 47);
        label4.TabIndex = 4;
        label4.Text = "Anno";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(25, 266);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(232, 47);
        label5.TabIndex = 5;
        label5.Text = "pagine";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(25, 328);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(232, 47);
        label6.TabIndex = 6;
        label6.Text = "prezzo";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(315, 169);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(379, 28);
        comboBox1.TabIndex = 7;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(315, 120);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(379, 27);
        textBox1.TabIndex = 8;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(315, 219);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(379, 27);
        textBox2.TabIndex = 9;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(315, 266);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(379, 27);
        textBox3.TabIndex = 10;
        // 
        // textBox4
        // 
        textBox4.Location = new System.Drawing.Point(315, 325);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(379, 27);
        textBox4.TabIndex = 11;
        // 
        // creaLibro
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(comboBox1);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button1);
        Text = "creaLibro";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;

    #endregion
}