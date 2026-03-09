using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Hello, World!");

// Nome dell'utente
string nome;
nome = "lucia";

/*
Libro:classe
libro():costruttore di default(==senza parametri) della classe libro
uno: istanza della classe libro noto come OGGETTO cioè una VARIABILE DI TIPO LIBRO (CLASSE)
*/

// Creazione libri
Libro uno = new Libro(); // DICHIARAZIONE E ASSEGNAMENTO tramite COSTRUTTORE
Libro due = new Libro("Il ritorno del re", "Tolkien", 1954, 1300, 17.10f);

// Lista libri
List<Libro> elenco = new List<Libro>();
elenco.Add(uno);
elenco.Add(due);

Console.WriteLine($"Il libro preferito da {nome} è {due.getTitolo()}");

// Liste autori e libri
List<Autore> autori = new List<Autore>();
List<Libro> libri = new List<Libro>();

// Controllo se i CSV esistono
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
        var autore = autori.FirstOrDefault(x => x.NomeCompleto == parts[1]);
        if (autore != null)
        {
            Libro l = new Libro(parts[0], autore.NomeCompleto, int.Parse(parts[2]), int.Parse(parts[3]), float.Parse(parts[4]));
            libri.Add(l);
            autore.Aggiungi(l);
        }
    }
}
else
{
    // Creazione autori se file assenti
    Autore mario = new Autore("Mario", "Rossi", DateOnly.ParseExact("19850512", "yyyyMMdd"));
    Autore anna = new Autore("Anna", "Bianchi", DateOnly.ParseExact("19900220", "yyyyMMdd"));
    autori.Add(mario);
    autori.Add(anna);

    // Creazione libri
    Libro l1 = new Libro("Il ritorno del re", mario.NomeCompleto, 1954, 1300, 17.10f);
    Libro l2 = new Libro("Harry Potter e la Pietra Filosofale", anna.NomeCompleto, 1997, 223, 22.50f);
    libri.Add(l1);
    libri.Add(l2);

    mario.Aggiungi(l1);
    anna.Aggiungi(l2);
}

// Stampa libri
int pos = 0;
foreach (var l in libri)
    Console.WriteLine($"{pos++} - {l}");

// Salvataggio CSV autori
using (StreamWriter sw = new StreamWriter("autori.csv"))
{
    foreach (var a in autori)
        sw.WriteLine($"{a.CognomePubblico};{a.NomePubblico};{a.NascitaPubblica:yyyyMMdd}");
}

// Salvataggio CSV libri
using (StreamWriter sw = new StreamWriter("libri.csv"))
{
    foreach (var l in libri)
        sw.WriteLine($"{l.TitoloPubblico};{l.AutoreStr};{l.AnnoPubblico};{l.PaginePubbliche};{l.PrezzoPubblico}");
}