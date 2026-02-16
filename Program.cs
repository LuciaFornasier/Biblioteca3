using System.IO;   
Console.WriteLine("Hello, World!");

string nome;
nome="lucia";

/*
Libro:classe
libro():costruttore di default(==senza parametri) della classe libro
uno: istanza della classe libro noto come OGGETTO cioè una VARIABILE DI TIPO LIBRO (CLASSE)
*/

Libro  uno=new Libro();// DICHIARAZIONE E ASSEGNAMENTO tramite COSTRUTTORE
Libro due=new Libro("Il ritorno del re ","Tolkier",1954,1300,17.10f);
elenco.Add(uno);
elenco.Add(due);


Console.WriteLine($"Il libro preferito da {nome} è {due.getTitolo()}");



string filePath = "libri.txt";
        List<Autore> autori = new List<Autore>();
        List<Libro> libri = new List<Libro>();

        if (File.Exists("autori.csv") && File.Exists("libri.csv"))
        {
            foreach (var line in File.ReadAllLines("autori.csv"))
            {
                var parts = line.Split(';');
                DateOnly nascita = DateOnly.ParseExact(parts[3], "yyyyMMdd");
                Autore a = new Autore(parts[1], parts[0], nascita);
                autori.Add(a);
            }

            foreach (var line in File.ReadAllLines("libri.csv"))
            {
                var parts = line.Split(';');
                var autore = autori.FirstOrDefault(x => x.NomeCompleto == parts[1]);
                if (autore != null)
                {
                    Libro l = new Libro(parts[0], autore, int.Parse(parts[2]), int.Parse(parts[3]), float.Parse(parts[4]));
                    libri.Add(l);
                    autore.Aggiungi(l);
                }
            }
        }
        else
        {
            Autore mario = new Autore("Mario", "Rossi", DateOnly.ParseExact("19850512", "yyyyMMdd"));
            Autore anna = new Autore("Anna", "Bianchi", DateOnly.ParseExact("19900220", "yyyyMMdd"));
            autori.Add(mario);
            autori.Add(anna);

            Libro l1 = new Libro("Il ritorno del re", mario, 1954, 1300, 17.10f);
            Libro l2 = new Libro("Harry Potter e la Pietra Filosofale", anna, 1997, 223, 22.50f);
            libri.Add(l1);
            libri.Add(l2);

            mario.Aggiungi(l1);
            anna.Aggiungi(l2);
        }

        int pos = 0;
        foreach (var l in libri)
            Console.WriteLine($"{pos++} - {l}");

        using (StreamWriter sw = new StreamWriter("autori.csv"))
        {
            foreach (var a in autori)
                sw.WriteLine($"{a.Cognome};{a.Nome};{a.Nascita:yyyyMMdd}");
        }

        using (StreamWriter sw = new StreamWriter("libri.csv"))
        {
            foreach (var l in libri)
                sw.WriteLine($"{l.Titolo};{l.Autore.NomeCompleto};{l.Anno};{l.Pagine};{l.Prezzo}");
        }

