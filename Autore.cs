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
        this.genere = "";
        elenco = new List<Libro>();
    }
    public Autore()
    {
        this.nome="";
        this.cognome = "";
        this.nascita =DateOnly.MinValue();
        this.genere = "";
        elenco = new List<Libro>();
    }

 
    public Autore(string nome, string cognome, DateTime nascita, List<Libro> elenco, string genere)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.nascita = nascita;
        this.genere = "";
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
        return $"{nome} {cognome} ({nascita})";
    }
    
    public string RigaCSV
    {
        get
        {
            string dataNascita = nascita.ToString("yyyyMMdd");
            return $"{cognome};{nome};{genere};{dataNascita}";
        }
    }
 
    
    public string DaCSV
    {
        set
        {
            string[] campi = value.Split(';');
            if (campi.Length < 2) return;
            cognome = campi[0].Trim();
            nome    = campi[1].Trim();
            genere  = campi.Length > 2 ? campi[2].Trim() : "";
            nascita = campi.Length > 3 && !string.IsNullOrWhiteSpace(campi[3])
                ? DateOnly.ParseExact(campi[3].Trim(), "yyyyMMdd")
                : DateOnly.MinValue;
        }
    }
 
    
    public string[] DatiCSV
    {
        get { return RigaCSV.Split(';'); }
    }

}