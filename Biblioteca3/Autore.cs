public class Autore
{
    private DateOnly nascita;
    private string nome;
    private string cognome;
    private List<Libro> elenco;

    public Autore(string nome, string cognome, DateOnly nascita)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.nascita = nascita;
        elenco = new List<Libro>();
    }

    public Autore()
    {
        nome = "Specifica un nome";
        cognome = "Specifica un cognome";
        nascita = DateOnly.MinValue;
        elenco = new List<Libro>();
    }

    public Autore(string nome, string cognome, DateOnly nascita, List<Libro> elenco)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.nascita = nascita;
        this.elenco = elenco;
    }

    public int Aggiungi(Libro libronuovo)
    {
        this.elenco.Add(libronuovo);
        return this.elenco.Count;
    }

    public string NomeCompleto
    {
        get { return $"{cognome} {nome}"; }
    }

    public DateTime DataNascita
    {
        set { nascita = DateOnly.FromDateTime(value > DateTime.Now ? DateTime.Now : value); }
    }

    public List<Libro> Elenco
    {
        get { return elenco; }
    }

    public DateOnly NascitaPubblica { get { return nascita; } }
    public string NomePubblico { get { return nome; } }
    public string CognomePubblico { get { return cognome; } }

    public override string ToString()
    {
        return $"{nome} {cognome} {nascita} {string.Join(", ", elenco)}";
    }

    public string[] DatiCSV
    {
        get
        {
            List<string> dati = new List<string>();
            dati.Add(this.cognome);
            dati.Add(this.nome);
            dati.Add(this.nascita.ToString("yyyyMMdd"));
            return dati.ToArray();
        }
    }
}
