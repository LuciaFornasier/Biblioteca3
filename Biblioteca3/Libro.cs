public class Libro
{
    private string titolo;
    private Autore autore;
    private int anno;
    private int pagine;
    private float prezzo;
 
    public Libro()
    {
        titolo = "Specifica un titolo";
        autore = new Autore();
        anno = 0;
        pagine = 0;
        prezzo = 0.0f;
    }
 
    public Libro(string titolo, Autore autore, int anno, int pagine, float prezzo)
    {
        this.titolo = titolo;
        this.autore = autore;
        this.anno = anno;
        this.pagine = pagine;
        this.prezzo = prezzo;
    }

    public string getTitolo() { return titolo; }
 
    public override string ToString()
    {
        return $"'{titolo}' di {autore.NomeCompleto} ({anno}) - {pagine} pagine - {prezzo} euro";
    }
 
    public string TitoloPubblico   { get { return titolo; } }
    public Autore Autore       { get { return autore; } }
    public int    AnnoPubblico     { get { return anno;   } }
    public int    PaginePubbliche  { get { return pagine; } }
    public float  PrezzoPubblico   { get { return prezzo; } }
    public string NomeCompleto { get { return autore.NomeCompleto; } }
    
    public string RigaCSV
    {
        get { return $"{titolo};{autore};{anno};{pagine}"; }
    }
}
