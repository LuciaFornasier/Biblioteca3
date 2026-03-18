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

   /* public List<string> libriAutori(List<Libro> libri, out List<string> k)
    {
        k = new List<string>();
        foreach (Libro l in libri)
        {
            if (string.Compare(l.Autore.NomeCompleto, autori.NomeCompleto))
            {
                k.Add(l.Autore.NomeCompleto);
            }

        }

        return k;
    }

    public bool OttieniinfoAutore(string autore, out int totlibri, out string UltimoTitolo)
    {
        Autore a = ;
        Libro lib = a.Totlibri.Last;
        List<Autore> l = libriAutori();
        if (l.Count == 0)
        {
            totlibri = 0;
            UltimoTitolo = null;
            return false;
        }

        totlibri = l[0].libri.Count;
        UltimoTitolo = l[0].libri[0].Titolo;
        return true;
    }

    public int VerificaDisponibilita(List<Libro> libri, string titolo, out int pos, out bool piùcopie)
    {

        for (int i = 0; i < libri.Count; i++)
        {
            if (libri.TitoloPubblico == titolo)
            {

            }
        }
    }

  /*  public CercaRangeDecennio(List<Libro> libri)
    {


    }
    */

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