namespace Biblioteca;

public partial class Autore : Form
{
    public Autore()
    {
        InitializeComponent();
        Autore = Biblioteca.CaricaBiblioteca();
        this.Text = $"Biblioteca'{Autore.Nome}";
        foreach (Autore autore in new List<Autore>())
        {
            string[] labels = autore.items;
            ListViewItem item = new ListViewItem(){Text = labels[0], Tag = autore};
            item.SubItems.AddRange(labels.skip(1).ToArray());
            ListViewAutori.Items.Add(item);
        }
        {
            
        }

    }

    void button1_Click(object sender, EventArgs e)
    {
        
    }

    void Button1_Click(object sender, EventArgs e)
    {
        textBox1= nome
        
    }
}