using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Hello, World!");

string nome = "lucia";

Libro uno = new Libro();
Libro due = new Libro("Il ritorno del re", "Tolkien", 1954, 1300, 17.10f);
Console.WriteLine($"Il libro preferito da {nome} è {due.getTitolo()}");

List<Autore> autori = new List<Autore>();
List<Libro>  libri  = new List<Libro>();

string percorso   = Directory.GetCurrentDirectory();
string autoriPath = Path.Combine(percorso, "autori.csv");
string libriPath  = Path.Combine(percorso, "libri.csv");

if (File.Exists(autoriPath) && File.Exists(libriPath))
{
    using (StreamReader reader = new StreamReader(autoriPath))
    {
        reader.ReadLine();
        while (!reader.EndOfStream)
        {
            string line     = reader.ReadLine() ?? "";
            string[] fields = line.Split(';');
            if (line.Length == 0 || fields.Length < 2) continue;
            Autore a = new Autore();
            a.DaCSV = line;
            autori.Add(a);
        }
    }

    using (StreamReader reader = new StreamReader(libriPath))
    {
        reader.ReadLine();
        while (!reader.EndOfStream)
        {
            string line     = reader.ReadLine() ?? "";
            string[] fields = line.Split(';');
            if (line.Length == 0 || fields.Length < 4) continue;
            Autore? autore = autori.FirstOrDefault(a => a.NomeCompleto == fields[1].Trim());
            if (autore == null) continue;
            Libro l = new Libro(fields[0].Trim(), autore.NomeCompleto, int.Parse(fields[2]), int.Parse(fields[3]), 0f);
            libri.Add(l);
            autore.Aggiungi(l);
        }
    }
}
else
{
    Autore mario = new Autore("Mario", "Rossi", DateOnly.ParseExact("19850512", "yyyyMMdd"));
    Autore anna  = new Autore("Anna",  "Bianchi", DateOnly.ParseExact("19900220", "yyyyMMdd"));
    mario.GenerePubblico = "M";
    anna.GenerePubblico  = "F";

    Libro l1 = new Libro("Il ritorno del re",                   mario.NomeCompleto, 1954, 1300, 17.10f);
    Libro l2 = new Libro("Harry Potter e la Pietra Filosofale", anna.NomeCompleto,  1997,  223, 22.50f);

    mario.Aggiungi(l1);
    anna.Aggiungi(l2);

    autori.Add(mario);
    autori.Add(anna);
    libri.Add(l1);
    libri.Add(l2);
}

int pos = 0;
foreach (var l in libri)
    Console.WriteLine($"{pos++} - {l}");

using (StreamWriter sw = new StreamWriter(autoriPath))
{
    sw.WriteLine("cognome;nome;genere;nascita");
    foreach (Autore a in autori)
        sw.WriteLine(a.RigaCSV);
}

using (StreamWriter sw = new StreamWriter(libriPath))
{
    sw.WriteLine("titolo;autore;anno;pagine");
    foreach (Libro l in libri)
        sw.WriteLine(l.RigaCSV);
}

Console.WriteLine($"File salvati in: {percorso}");