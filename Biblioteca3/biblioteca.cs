using System;
using System.Collections.Generic;
using System.Linq;
namespace biblioteca;

public class Biblioteca
{
    private string nome;
    private List<Autore> autori = new List<Autore>();
    private List<Libro> libri = new List<Libro>();

    public Biblioteca(string nomeBiblioteca)
    {
        this.nome = nomeBiblioteca;
    }

    public override string ToString()
    {
        return $"Biblioteca '{this.nome}' - [Autori: {this.autori.Count} - Libri: {this.libri.Count}]";
    }

    public int AggiungiAutore(Autore autore)
    {
        this.autori.Add(autore);
        return this.autori.Count;
    }

    public int AggiungiLibro(Libro libro)
    {
        this.libri.Add(libro);
        return this.libri.Count;
    }

    public Autore[] AutoriInAnno(int anno)
    {
        return this.autori.FindAll(autore => autore.NascitaPubblica.Year == anno).ToArray();
    }

    public Libro[] LibriInAnno(int anno)
    {
        return this.libri.FindAll(libro => libro.AnnoPubblico == anno).ToArray();
    }

    public Autore[] ElencoAutori
    {
        get { return this.autori.ToArray(); }
    }

    public Libro[] ElencoLibri
    {
        get { return this.libri.ToArray(); }
    }

    public int TotalePagine
    {
        get { return this.libri.Sum(libro => libro.PaginePubbliche); }
    }

    public string SalvaCSV()
    {
        string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        using (StreamWriter streamAutori = new StreamWriter(Path.Combine(docPath, "Autori.csv")))
        {
            foreach (Autore autore in this.autori)
            {
                //cognome;nome;genere;nascita
                streamAutori.WriteLine(autore.DatiCSV);
            }
        }

        using (StreamWriter streamLibri = new StreamWriter(Path.Combine(docPath, "libri.csv")))
        {
            foreach (Libro libro in this.libri)
            {
                //titolo;autore;anno;pagine
                streamLibri.WriteLine(libro);
            }
        }

        return docPath;

    }

    public Autore[] CaricaCSV(string filePath)
    {
        List<Autore> autori = new List<Autore>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            string[] fields;

            Console.WriteLine($"Testata: {reader.ReadLine()}");

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine() ?? "";
                fields = line.Split(',');

                if (line.Length == 0 || fields.Length < 4)
                {
                    Console.WriteLine($"Errore: {line}");
                    continue;
                }

                string[] datiAutore = fields[2].Split('#');

                string nome = datiAutore[0].Trim();
                string cognome = datiAutore.Length > 1 ? datiAutore[1].Trim() : "";

                Autore autore = new Autore(nome, cognome);

                autori.Add(autore);
            }
        }

        return autori.ToArray();
    }

    public static Biblioteca CaricaBiblioteca()
    {
        Biblioteca b = new Biblioteca("Lucy");

        Autore mario = new Autore("Mario", "Rossi", new DateOnly(1985, 5, 12));
        Autore joanne = new Autore("Joanne", "Rowling", new DateOnly(1965, 7, 31));
        Autore tolkien = new Autore("John", "Tolkien", new DateOnly(1892, 1, 3));

        b.AggiungiAutore(mario);
        b.AggiungiAutore(joanne);
        b.AggiungiAutore(tolkien);

        Libro l1 = new Libro("Il ritorno del re", tolkien, 1954, 1300, 17.10f);
        Libro l2 = new Libro("Harry Potter e la Pietra Filosofale", joanne, 1997, 223, 22.50f);
        Libro l3 = new Libro("Manuale di Programmazione", mario, 2020, 350, 25.00f);

        tolkien.Aggiungi(l1);
        joanne.Aggiungi(l2);
        mario.Aggiungi(l3);

        b.AggiungiLibro(l1);
        b.AggiungiLibro(l2);
        b.AggiungiLibro(l3);

        return b;
    }

    public string Nome
    {
        get { return nome; }
    }

    public List<Libro> TrovaLibriAutore(List<Autore> autori, string nomeAutore)
    {
        CercaAutore(autori, nomeAutore, out string? nomeRisultato);

        if (nomeRisultato == null)
            return new List<Libro>(); // Autore non trovato, lista vuota

        Autore autore = autori.First(a =>
            string.Equals(a.NomeCompleto, nomeRisultato, StringComparison.OrdinalIgnoreCase));

        return autore.Elenco ?? new List<Libro>();
    }

    public void OrdinaPerTitolo(List<Libro> Libri, out List<Libro> ordina)
    {
        ordina = null;
        ordina = libri.OrderBy(a => a.TitoloPubblico).ToList();
        return;
    }

    public bool OttieniInfoAutore(string nomeAutore, List<Autore> autori, out int totLibri, out string ultimoTitolo)
    {
        totLibri = 0;
        ultimoTitolo = null;
        List<Libro> libriAutore = TrovaLibriAutore(autori, nomeAutore);

        if (libriAutore.Count == 0)
            return false;

        Libro ultimoLibro = libriAutore
            .OrderBy(l => l.AnnoPubblico)
            .Last();

        totLibri = libriAutore.Count;
        ultimoTitolo = ultimoLibro.TitoloPubblico;

        return true;
    }

    public int VerificaDisponibilita(List<Libro> libriOrdinati, string titolo, out int pos, out bool piuCopie)
    {
        pos = -1;
        piuCopie = false;
        int copie = 0;

        for (int i = 0; i < libriOrdinati.Count; i++)
        {
            if (libriOrdinati[i].TitoloPubblico == titolo)
            {
                if (pos == -1)
                    pos = i; 

                copie++;
            }
        }

        if (copie == 0)
            return 0; 

        piuCopie = copie > 1;
        return copie;
    }

    public bool CercaRangeDecennio(List<Libro> libriOrdinati, int inizioDecennio, out Libro primo, out Libro ultimo)
    {
        primo = null;
        ultimo = null;
        int fineDecennio = inizioDecennio + 9;

        for (int i = 0; i < libriOrdinati.Count; i++)
        {
            int anno = libriOrdinati[i].AnnoPubblico;

            if (anno >= inizioDecennio && anno <= fineDecennio)
            {
                if (primo == null)
                    primo = libriOrdinati[i];

                ultimo = libriOrdinati[i]; 
            }
        }

        return primo != null; 
    }

    public void InserisciAutoreInOrdine(ref List<Autore> autoriOrdinati, Autore nuovoAutore)
    {
        foreach (Autore a in autoriOrdinati)
        {
            if (string.Equals(a.NomeCompleto, nuovoAutore.NomeCompleto, StringComparison.OrdinalIgnoreCase))
                return; 
        }

        
        for (int i = 0; i < autoriOrdinati.Count; i++)
        {
            int cmp = string.Compare(
                autoriOrdinati[i].NomeCompleto,
                nuovoAutore.NomeCompleto,
                StringComparison.OrdinalIgnoreCase);

            if (cmp > 0) 
            {
                autoriOrdinati.Insert(i, nuovoAutore);
                return;
            }
        }

        autoriOrdinati.Add(nuovoAutore);
    }

    public void OrdinaPerAutore(List<Libro> libri, out List<Libro> ordinati)
    {
        ordinati = libri.OrderBy(l => l.NomeCompleto).ToList();
    }

    public void OrdinaPerAnno(List<Libro> Libri, out List<Libro> ordinati)
    {
        ordinati=Libri.OrderBy(a => a.AnnoPubblico).ToList();
    }
    public void CercaAutore(
        List<Autore> autori,
        string autor,
        out string? autore)
    {
        autore = "";

        // La dicotomica richiede lista ordinata
        List<Autore> ordinati = autori
            .OrderBy(a => a.NomeCompleto, StringComparer.OrdinalIgnoreCase)
            .ToList();

        int sx = 0, dx = ordinati.Count - 1;

        while (sx <= dx)
        {
            int centro = (sx + dx) / 2;
            int cmp = string.Compare(
                ordinati[centro].NomeCompleto,
                autor,
                StringComparison.OrdinalIgnoreCase);

            if (cmp == 0)
            {
                autore = ordinati[centro].NomeCompleto;
                return;
            }

            if (cmp < 0) sx = centro + 1;
            else dx = centro - 1;
        }
    }

    public void Cercalibro(List<Libro> libri, string titolo, out string? libro)
    {
        foreach (Libro v in libri)
        {
            if (v.TitoloPubblico.Equals(titolo, StringComparison.OrdinalIgnoreCase))
            {
                libro = v.TitoloPubblico;
                return;
            }
        }

        libro = null;
    }

    public void AnnoLibri(List<Libro> libri, int date, out List<Libro> l, out int tot)
    {
        l = new List<Libro>();
        tot = 0;
        foreach (Libro v in libri)
        {
            if (v.AnnoPubblico == date)
            {
                l.Add(v);
                tot++;
            }

        }
    }
}