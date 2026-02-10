//libro titolo, autore, anno, pagine
public class Libro
{
    string titolo;
    string autore;
    int anno;
    int pagine;
    float prezzo;
    // Metodi
    /// <summary>
    /// Costruttore di default
    /// </summary>
    public Libro()
    {
    titolo="Specifica un titolo";
    autore="Scegli un autore";
    anno=0;
    pagine=0;
    prezzo=0.0f;
    }
    /// <summary>
    /// Costruttore con parametri
    /// </summary>
    public Libro(string titolo, string autore, int anno, int pagine,float prezzo)
    {
        this.titolo = titolo;
        this.autore = autore;
        this.anno = anno;
        this.pagine = pagine;
        this.prezzo = prezzo;
    }
    /// <summary>
    /// Ritorna il titolo del libro
    /// </summary>
    /// <returns>Il titolo</returns>
    public string getTitolo()
    {
        return this.titolo;
    }
    public override string ToString()
    {
       return $"'{this.titolo}' di {this.autore} ({this.anno}) - {this.pagine} pagine - {this.prezzo} euro";
};

