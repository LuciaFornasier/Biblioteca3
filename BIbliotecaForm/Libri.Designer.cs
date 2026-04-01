using System.ComponentModel;

namespace BIbliotecaForm;

partial class Libri
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
        listView1 = new System.Windows.Forms.ListView();
        TitoloHeader1 = new System.Windows.Forms.ColumnHeader();
        AutoreHeader = new System.Windows.Forms.ColumnHeader();
        annoHeader = new System.Windows.Forms.ColumnHeader();
        pagineHeader1 = new System.Windows.Forms.ColumnHeader();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { TitoloHeader1, AutoreHeader, annoHeader, pagineHeader1 });
        listView1.Dock = System.Windows.Forms.DockStyle.Fill;
        listView1.FullRowSelect = true;
        listView1.Location = new System.Drawing.Point(0, 0);
        listView1.MultiSelect = false;
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(800, 450);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        // 
        // TitoloHeader1
        // 
        TitoloHeader1.Name = "TitoloHeader1";
        TitoloHeader1.Tag = "Titolo";
        TitoloHeader1.Text = "Titolo";
        TitoloHeader1.Width = 197;
        // 
        // AutoreHeader
        // 
        AutoreHeader.Name = "AutoreHeader";
        AutoreHeader.Tag = "autore";
        AutoreHeader.Text = "Autore";
        AutoreHeader.Width = 202;
        // 
        // annoHeader
        // 
        annoHeader.Name = "annoHeader";
        annoHeader.Tag = "anno";
        annoHeader.Text = "Anno";
        annoHeader.Width = 201;
        // 
        // pagineHeader1
        // 
        pagineHeader1.Name = "pagineHeader1";
        pagineHeader1.Tag = "Pagine";
        pagineHeader1.Text = "Pagine";
        pagineHeader1.Width = 170;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(199, 357);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(356, 55);
        button1.TabIndex = 1;
        button1.Text = "Nuovo libro";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Libri
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(listView1);
        Text = "Libri";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.ColumnHeader AutoreHeader;
    private System.Windows.Forms.ColumnHeader annoHeader;

    private System.Windows.Forms.ColumnHeader TitoloHeader1;
    private System.Windows.Forms.ColumnHeader pagineHeader1;

    private System.Windows.Forms.ListView listView1;

    #endregion
}