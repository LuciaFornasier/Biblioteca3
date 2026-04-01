using System.ComponentModel;

namespace BIbliotecaForm;

partial class CreaAutore
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
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(48, 198);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(197, 35);
        label1.TabIndex = 0;
        label1.Text = "Nome";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(48, 254);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(197, 35);
        label2.TabIndex = 1;
        label2.Text = "Cognome";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(48, 328);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(197, 35);
        label3.TabIndex = 2;
        label3.Text = "Data di nascita";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(292, 73);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(351, 59);
        label4.TabIndex = 3;
        label4.Text = "Autore";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(296, 191);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(347, 27);
        textBox1.TabIndex = 4;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(296, 254);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(347, 27);
        textBox2.TabIndex = 5;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(296, 325);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(347, 27);
        textBox3.TabIndex = 6;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(262, 389);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(307, 49);
        button1.TabIndex = 7;
        button1.Text = "Crea";
        button1.UseVisualStyleBackColor = true;
        // 
        // CreaAutore
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "CreaAutore";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label1;

    #endregion
}