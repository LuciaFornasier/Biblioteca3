using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using biblioteca;

Console.WriteLine("Hello, World!");

string nome = "Lucia";

List<Autore> autori = new List<Autore>();
List<Libro> libri = new List<Libro>();

Biblioteca biblioteca;

// Se esistono i file CSV li carico
if (File.Exists("autori.csv") && File.Exists("libri.csv"))
{
    foreach (var line in File.ReadAllLines("autori.csv"))
    {
        var parts = line.Split(';');

        DateOnly nascita = DateOnly.ParseExact(parts[2], "yyyyMMdd");
        Autore a = new Autore(parts[1], parts[0], nascita);

        autori.Add(a);
    }

    foreach (var line in File.ReadAllLines("libri.csv"))
    {
        var parts = line.Split(';');

         Autore? autore = autori.FirstOrDefault(x => x.NomeCompleto == parts[0]);

        if (autore != null)
        {
            Libro l = new Libro(
                parts[0],
                autore.NomeCompleto,
                int.Parse(parts[2]),
                int.Parse(parts[3]),
                float.Parse(parts[4], CultureInfo.InvariantCulture)
            );

            libri.Add(l);
            autore.Aggiungi(l);
        }
    }
}
else
{
    biblioteca = Biblioteca.CaricaBiblioteca();

    autori = biblioteca.ElencoAutori.ToList();
    libri = biblioteca.ElencoLibri.ToList();
}

// Stampa libri
int pos = 0;
foreach (var l in libri)
{
    Console.WriteLine($"{pos++} - {l}");
}

// Salva CSV autori
using (StreamWriter sw = new StreamWriter("autori.csv"))
{
    foreach (var a in autori)
    {
        sw.WriteLine($"{a.CognomePubblico};{a.NomePubblico};{a.NascitaPubblica:yyyyMMdd}");
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