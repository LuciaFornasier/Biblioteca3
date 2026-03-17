using biblioteca;

namespace BIbliotecaForm;

public partial class BibliotecaForm : Form
{
    public BibliotecaForm()
    {
        InitializeComponent();
        Biblioteca biblio = Biblioteca.CaricaBiblioteca();
        this.Text = $"Biblioteca '{biblio.Nome}'";
        foreach (Autore autore in biblio.ElencoAutori)
        {
            string[] labels = autore.DatiCSV; // Proprietà con tutti i dati per le colonne
            ListViewItem item = new ListViewItem() { Text = labels[0], Tag = autore };
            item.SubItems.AddRange(labels.Skip(1).ToArray()); // Array delle colonne rimanenti
            ListViewAutori.Items.Add(item);
        }
    }

  private void ListViewAutori_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // logica per la selezione dell'autore
        }

        private void Autore_Click(object sender, EventArgs e)
        {
            // logica per il pulsante Nuovo Autore
            if (ListViewAutori.SelectedItems.Count == 0)
            {
        
            }
        }


}



    
