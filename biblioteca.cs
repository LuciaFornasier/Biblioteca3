using System;
using System.Collections.Generic;
using System.Linq;
namespace biblioteca;
public class Biblioteca{
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
                streamAutori.WriteLine(autore);
            }
        }

        using (StreamWriter streamLibri = new StreamWriter( Path.Combine(docPath,"libri.csv")))
        {
            foreach (Libro libro in this.libri)
            {
                //titolo;autore;anno;pagine
                streamLibri.WriteLine(libro);
            }
        }
        return docPath;

    }
}