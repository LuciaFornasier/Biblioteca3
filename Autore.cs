using System.Reflection.Metadata.Ecma335;

public class Autore {
    DateOnly nascita;
    string nome;    
    string cognome;
    List<Libro> elenco;
    public Autore(string nome, string cognome, DateOnly nascita) {
      elenco=new  List<Libro>();

    }
    public Autore()
    {
        nome="Specifica un nome";
        cognome="Specifica un cognome";
        nascita=DateOnly.MinValue;
        elenco=new List<Libro>();
    }
    public Autore(string nome, string cognome, DateOnly nascita, List<Libro> elenco) {
      this.nome=nome;
      this.cognome=cognome;
      this.nascita=nascita;
      this.elenco=elenco;
    }
        public int Aggiungi(Libro libronuovo){
        this.elenco.Add(libronuovo);
        return this.elenco.Count;
    }
    public String NomeCompleto
    {
        get{ return $"{cognome} {nome}";}
    }
    public DateTime DataNascita
    {
        set{ this.nascita = DateOnly.FromDateTime(value > DateTime.Now ? DateTime.Now : value); }
    }
};





