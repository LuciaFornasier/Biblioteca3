using System;
using System.Linq;
using System.Windows.Forms;
using biblioteca;

namespace BIbliotecaForm
{
    public partial class BibliotecaForm : Form
    {
        private System.Windows.Forms.ListView ListViewAutori;
        private ColumnHeader HeaderCognome;
        private ColumnHeader headerNome;
        private ColumnHeader headerNascita;
        private ColumnHeader headerTotlibri;
        private System.Windows.Forms.Button Autore;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewAutori = new System.Windows.Forms.ListView();
            HeaderCognome = new System.Windows.Forms.ColumnHeader();
            headerNome = new System.Windows.Forms.ColumnHeader();
            headerNascita = new System.Windows.Forms.ColumnHeader();
            headerTotlibri = new System.Windows.Forms.ColumnHeader();
            Autore = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ListViewAutori
            // 
            ListViewAutori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { HeaderCognome, headerNome, headerNascita, headerTotlibri });
            ListViewAutori.Dock = System.Windows.Forms.DockStyle.Fill;
            ListViewAutori.FullRowSelect = true;
            ListViewAutori.Location = new System.Drawing.Point(0, 0);
            ListViewAutori.MultiSelect = false;
            ListViewAutori.Name = "ListViewAutori";
            ListViewAutori.Size = new System.Drawing.Size(800, 450);
            ListViewAutori.TabIndex = 0;
            ListViewAutori.UseCompatibleStateImageBehavior = false;
            ListViewAutori.View = System.Windows.Forms.View.Details;
            ListViewAutori.SelectedIndexChanged += ListViewAutori_SelectedIndexChanged_1;
            // 
            // HeaderCognome
            // 
            HeaderCognome.Name = "HeaderCognome";
            HeaderCognome.Text = "Cognome";
            HeaderCognome.Width = 155;
            // 
            // headerNome
            // 
            headerNome.Name = "headerNome";
            headerNome.Text = "Nome";
            headerNome.Width = 134;
            // 
            // headerNascita
            // 
            headerNascita.Name = "headerNascita";
            headerNascita.Text = "Nascita";
            headerNascita.Width = 238;
            // 
            // headerTotlibri
            // 
            headerTotlibri.Name = "headerTotlibri";
            headerTotlibri.Text = "TotLibri";
            headerTotlibri.Width = 413;
            // 
            // Autore
            // 
            Autore.Location = new System.Drawing.Point(320, 344);
            Autore.Name = "Autore";
            Autore.Size = new System.Drawing.Size(166, 34);
            Autore.TabIndex = 1;
            Autore.Text = "Nuovo Autore";
            Autore.UseVisualStyleBackColor = true;
            Autore.Click += Autore_Click;
            // 
            // BibliotecaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(Autore);
            Controls.Add(ListViewAutori);
            Text = "Biblioteca";
            ResumeLayout(false);
        }
    }
}