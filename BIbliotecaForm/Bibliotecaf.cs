namespace BIbliotecaForm;

using bib = biblioteca; 

public partial class Bibliotecaf : Form
{
    public Bibliotecaf()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Libri form = new Libri(); 
        form.Owner = this;
        form.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Autore forms = new Autore(); 
        forms.Owner = this;
        forms.Show();
    }
}