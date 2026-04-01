namespace BIbliotecaForm;
    public partial class BibliotecaForm : Form
    {
        public BibliotecaForm()
        {
            InitializeComponent();
        }

        private void ListViewAutori_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ListViewAutori.SelectedItems.Count > 0)
            {
                
                ListViewItem item = ListViewAutori.SelectedItems[0];
                string cognome = item.Text;
                string nome = item.SubItems[1].Text;
            }
        }

        private void Autore_Click(object sender, EventArgs e)
        {
            
        }
    }