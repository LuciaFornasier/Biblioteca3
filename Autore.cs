using System;
using System.Collections.Generic;

public class Autore
{
    DateOnly nascita;
    string nome;
    string cognome;
    List<Libro> elenco;

    /// <summary>
    /// Costruttore con nome, cognome e nascita
    /// </summary>
    public Autore(string nome, string cognome, DateOnly nascita)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.nascita = nascita;
        elenco = new List<Libro>();
    }

    /// <summary>
    /// Costruttore di default
    /// </summary>
    public Autore()
    {
        nome = "Specifica un nome";
        cognome = "Specifica un cognome";
        nascita = DateOnly.MinValue;
        elenco = new List<Libro>();
    }

    /// <summary>
    /// Costruttore con lista di libri
    /// </summary>
    public Autore(string nome, string cognome, DateOnly nascita, List<Libro> elenco)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.nascita = nascita;
        this.elenco = elenco ?? new List<Libro>();
    }

    /// <summary>
    /// Aggiunge un libro alla lista e ritorna il numero di libri
    /// </summary>
    public int Aggiungi(Libro libronuovo)
    {
        this.elenco.Add(libronuovo);
        return this.elenco.Count;
    }

    /// <summary>
    /// Ritorna il nome completo
    /// </summary>
    public string NomeCompleto
    {
        get { return $"{cognome} {nome}"; }
    }

    /// <summary>
    /// Imposta la data di nascita
    /// </summary>
    public DateTime DataNascita
    {
        set { nascita = DateOnly.FromDateTime(value > DateTime.Now ? DateTime.Now : value); }
    }

    /// <summary>
    /// Restituisce la lista dei libri
    /// </summary>
    public List<Libro> Elenco
    {
        get { return elenco; }
    }

    // 🔹 Proprietà pubbliche per Program.cs
    public string NomePubblico { get { return nome; } }
    public string CognomePubblico { get { return cognome; } }
    public DateOnly NascitaPubblica { get { return nascita; } }
}