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

        Libro l1 = new Libro("Il ritorno del re", tolkien.NomeCompleto, 1954, 1300, 17.10f);
        Libro l2 = new Libro("Harry Potter e la Pietra Filosofale", joanne.NomeCompleto, 1997, 223, 22.50f);
        Libro l3 = new Libro("Manuale di Programmazione", mario.NomeCompleto, 2020, 350, 25.00f);

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
    
}