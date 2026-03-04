
public class Autore
{
    private DateOnly nascita;
    private string nome;
    private string cognome;
    private List<Libro> elenco;

    /// <summary>
    /// Costruttore con nome, cognome e nascita
    /// </summary>
    public Autore(string nome, string cognome, DateOnly nascita)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.nascita = nascita;
        elenco = new List<Libro>();
    }

    /// <summary>
    /// Costruttore di default
    /// </summary>
    public Autore()
    {
        nome = "Specifica un nome";
        cognome = "Specifica un cognome";
        nascita = DateOnly.MinValue;
        elenco = new List<Libro>();
    }

    /// <summary>
    /// Costruttore con lista di libri
    /// </summary>
    public Autore(string nome, string cognome, DateOnly nascita, List<Libro> elenco)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.nascita = nascita;
        this.elenco = elenco;
    }

    /// <summary>
    /// Aggiunge un libro alla lista e ritorna il numero di libri
    /// </summary>
    public int Aggiungi(Libro libronuovo)
    {
        this.elenco.Add(libronuovo);
        return this.elenco.Count;
    }

    /// <summary>
    /// Ritorna il nome completo
    /// </summary>
    public string NomeCompleto
    {
        get { return $"{cognome} {nome}"; }
    }

    /// <summary>
    /// Imposta la data di nascita
    /// </summary>
    public DateTime DataNascita
    {
        set { nascita = DateOnly.FromDateTime(value > DateTime.Now ? DateTime.Now : value); }
    }

    /// <summary>
    /// Restituisce la lista dei libri
    /// </summary>
    public List<Libro> Elenco
    {
        get { return elenco; }
    }
    public DateOnly NascitaPubblica { get { return nascita; } }

    public override string ToString()
    {
        return $"{nome} {cognome} {nascita} {string.Join(", ",elenco)}";
    }
    public string[] DatiCSV
    {
        get
        {
            List<string> dati=new List<string>();
            dati.Add(this.cognome);
            dati.Add(this.nome);
            dati.Add(this.nascita);
            return dati.ToArray();
        }
    }
}