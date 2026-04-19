using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using biblioteca;


string nome = "Lucia";

List<Autore> autori = new List<Autore>();

List<Libro> libri = new List<Libro>();

Biblioteca biblioteca;

// Se esistono i file CSV li carico
foreach (var line in File.ReadAllLines("autori.csv").Skip(1))
{
    if (string.IsNullOrWhiteSpace(line)) continue;

    var parts = line.Split(';');
    
    DateOnly nascita = DateOnly.ParseExact(
        parts[2],
        new[] { "dd-MM-yyyy", "d-M-yyyy", "d-MM-yyyy", "dd-M-yyyy" },
        CultureInfo.InvariantCulture,
        DateTimeStyles.None
    );

    Autore a = new Autore(parts[1], parts[0], nascita);
    autori.Add(a);
}

foreach (var line in File.ReadAllLines("libri.csv").Skip(1))
{
    var parts = line.Split(';');

    Autore? autor = autori.FirstOrDefault(x => x.NomeCompleto == parts[0]);

    if (autor != null)
    {
        Libro l = new Libro(
            parts[0],
            autor,
            int.Parse(parts[2]),
            int.Parse(parts[3]),
            float.Parse(parts[4], CultureInfo.InvariantCulture)
        );

        libri.Add(l);
        autor.Aggiungi(l);
    }
    else
    {
        biblioteca = Biblioteca.CaricaBiblioteca();

        autori = biblioteca.ElencoAutori.ToList();
        libri = biblioteca.ElencoLibri.ToList();
    }

}

// Stampa libri
    int pos = 0;
    foreach (var l in libri)
    {
        Console.WriteLine($"{pos++} - {l}");
    }

// Salva CSV auto
    using (StreamWriter sw = new StreamWriter("autori.csv"))
    {
        sw.WriteLine("cognome;nome;nascita");
        foreach (var a in autori)
        {
            sw.WriteLine($"{a.CognomePubblico};{a.NomePubblico};{a.NascitaPubblica:dd-MM-yyyy}");
        }
    }

// Salva CSV libri
    using (StreamWriter sw = new StreamWriter("libri.csv"))
    {
        foreach (var l in libri)
        {
            sw.WriteLine($"{l.TitoloPubblico};{l.Autore};{l.AnnoPubblico};{l.PaginePubbliche};{l.PrezzoPubblico}");
        }
    }


Biblioteca b = Biblioteca.CaricaBiblioteca();

// Versione void
    b.CercaAutore(b.ElencoAutori.ToList(), "Harry", out string autore);
    if (autore != "")
        Console.WriteLine($"Autore: {autore}");

    List<string> c= new List<string>();
    foreach (Autore v in autori)
    {
        c.Add(v.DataENome);
    }
Console.WriteLine($"Gli autori:{string.Join(",",c)}");

string path = Path.GetFullPath("autori.csv");
Console.WriteLine($"Leggo da: {path}");
Console.WriteLine("Contenuto:");
foreach (var l in File.ReadAllLines(path))
    Console.WriteLine(l);