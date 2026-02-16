public class Autore {
    string nome;
    string cognome;
    DateOnly nascita;
    public Autore(){
        nome="Specifica un nome";
        cognome="Specifica un cognome";
        nascita=nascita.Minvalue
    }
    
    public Autore(string nome, string cognome, DateOnly nascita){
        this.nome=nome;
        this.cognome=cognome;
        this.nascita=nascita;
        this.libri=new List<Libro>;
    
    }
    
        private list<Libro> libri;
    
        public int  Aggiungi(Libro libronuovo)
        {
            this.libri.Add(libronuovo);
            return this.libri.Count;
        }

}






