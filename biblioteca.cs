using System;
using System.Collections.Generic;
using System.Linq;
namespace biblioteca;

public class Biblioteca
{
    private string nome;
    private List<Autore> autori;
    private List<Libro> libri;
    public Biblioteca(string nomeBiblioteca)
    {
        this.nome = nomeBiblioteca;
        this.libri = libri;
        this.autori = autori;
    }

    public Biblioteca()
    {
        autori = new List<Autore>();
        libri = new List<Libro>();
        nome = "";

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


    public string SalvaCSV(string percorso)
    {
        //  cognome;nome;genere;nascita
        using (StreamWriter sw = new StreamWriter(Path.Combine(percorso, "autori.csv")))
        {
            sw.WriteLine("cognome;nome;genere;nascita");
            foreach (Autore a in this.autori)
                sw.WriteLine(a.RigaCSV);
        }

        // titolo;autore;anno;pagine
        using (StreamWriter sw = new StreamWriter(Path.Combine(percorso, "libri.csv")))
        {
            sw.WriteLine("titolo;autore;anno;pagine");
            foreach (Libro l in this.libri)
                sw.WriteLine(l.RigaCSV);
        }

        return percorso;
    }

    public int CaricaCSV(string percorso)
    {
        string autoriPath = Path.Combine(percorso, "autori.csv");
        string libriPath = Path.Combine(percorso, "libri.csv");
        string[] campi = line.Split(';');
        string cognome = campi[0].Trim();
        string nome    = campi[1].Trim();
        DateOnly nascita = campi.Length > 3 && !string.IsNullOrWhiteSpace(campi[3])
            ? DateOnly.ParseExact(campi[3].Trim(), "yyyyMMdd")
            : DateOnly.MinValue;
        Autore autore1 = new Autore(nome, cognome, nascita);
        this.AggiungiAutore(autore1);

        using (StreamReader reader = new StreamReader(autoriPath))
        {
            Console.WriteLine($"Testata autori: {reader.ReadLine()}");

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine() ?? "";
                string[] fields = line.Split(';');

                if (line.Length == 0 || fields.Length < 2)
                {
                    Console.WriteLine($"Riga NON conforme: {line}");
                    continue;
                }


                Autore autore = new Autore();
                autore= line;
                this.AggiungiAutore(autore);
            }
        }


        int contatore = 0;

        using (StreamReader reader = new StreamReader(libriPath))
        {
            Console.WriteLine($"Testata libri: {reader.ReadLine()}"); // salta testata

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine() ?? "";
                string[] fields = line.Split(';');

                if (line.Length == 0 || fields.Length < 4)
                {
                    Console.WriteLine($"Riga NON conforme: {line}");
                    continue;
                }

                // fields[1] = NomeCompleto dell'autore (cognome nome)
                Autore? autore = this.autori.FirstOrDefault(a => a.NomeCompleto == fields[1].Trim());

                if (autore == null)
                {
                    Console.WriteLine($"Autore non trovato: {fields[1]}");
                    continue;
                }

                int anno = int.Parse(fields[2]);
                int pagine = int.Parse(fields[3]);
                Libro libro = new Libro(fields[0].Trim(), autore.NomeCompleto, anno, pagine, 0f);

                this.AggiungiLibro(libro);
                autore.Aggiungi(libro);
                contatore++;
            }
        }

        return contatore;
    }


    public (bool valido, List<string> errori) ValidaDati()
    {
        List<string> errori = new List<string>();

        foreach (Autore a in this.autori)
        {
            string id = $"Autore '{a.NomeCompleto}'";
            if (string.IsNullOrWhiteSpace(a.NomePubblico))
                errori.Add($"{id}: nome mancante");
            if (string.IsNullOrWhiteSpace(a.CognomePubblico))
                errori.Add($"{id}: cognome mancante");
            if (a.NascitaPubblica == DateOnly.MinValue)
                errori.Add($"{id}: data di nascita mancante");
            if (a.NascitaPubblica > DateOnly.FromDateTime(DateTime.Now))
                errori.Add($"{id}: data di nascita nel futuro");
        }

        foreach (Libro l in this.libri)
        {
            string id = $"Libro '{l.TitoloPubblico}'";
            if (string.IsNullOrWhiteSpace(l.TitoloPubblico))
                errori.Add($"{id}: titolo mancante");
            if (string.IsNullOrWhiteSpace(l.AutoreStr))
                errori.Add($"{id}: autore mancante");
            else if (!this.autori.Any(a => a.NomeCompleto == l.AutoreStr))
                errori.Add($"{id}: autore '{l.AutoreStr}' non trovato in biblioteca");
            if (l.AnnoPubblico <= 0)
                errori.Add($"{id}: anno non valido ({l.AnnoPubblico})");
            if (l.AnnoPubblico > DateTime.Now.Year)
                errori.Add($"{id}: anno nel futuro ({l.AnnoPubblico})");
            if (l.PaginePubbliche <= 0)
                errori.Add($"{id}: numero pagine non valido ({l.PaginePubbliche})");
        }

        return (errori.Count == 0, errori);
    }

    public string Ordinamento {
        get
        {
            for(int i=0; i<this.autori.Count-1;i++)
            {
                for (int h = 0; h < this.autori.Count-1; h++)
                {
                    if(string.Compare(autori[h].NomeCompleto>autori[h+1].NomeCompleto)
                    {
                        Swap(ref autori[h].NomeCompleto,ref autori[h+1].NomeCompleto)
                    }
                }
            }
        }
    }
}

