public class Autore
{
    private DateOnly nascita;
    private string nome;
    private string cognome;
    private string genere;
    private List<Libro> elenco;
 
    public Autore(string nome, string cognome, DateOnly nascita)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.nascita = nascita;
        this.genere = genere;
        this.elenco = elenco;
    }
    public Autore()
    {
        nome="";
        cognome = "";
        nascita =DateOnly.MinValue();
        genere = "";
        elenco = new List<Libro>();
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
 
    public DateOnly NascitaPubblica
    {
        get { return nascita; }
        set
        {
            this.nascita=DateOnly.FromDateTime(value  > DateTime.Now?DateTime.Now:value);
        }
    }
 
    public string NomePubblico
    {
        get { return nome; }
    }
 
    public string CognomePubblico
    {
        get { return cognome; }
    }
 
    public string GenerePubblico
    {
        get { return genere; }
        set { genere = value; }
    }
 
    public override string ToString()
    { 
        return $"{nome}, {cognome} ,{nascita}";
    }
    
    public string RigaCSV
    {
        get
        {
            string dataNascita = nascita.ToString("yyyyMMdd");
            return $"{cognome};{nome};{genere};{dataNascita}";
        }
    }
    public string[] DatiCSV
    {
        get { return RigaCSV.Split(';'); }
    }

}