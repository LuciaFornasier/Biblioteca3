
Console.WriteLine("Hello, World!");

string nome;
nome="lucia";

/*
Libro:classe
libro():costruttore di default(==senza parametri) della classe libro
uno: istanza della classe libro noto come OGGETTO cioè una VARIABILE DI TIPO LIBRO (CLASSE)
*/

Libro  uno=new Libro();// DICHIARAZIONE E ASSEGNAMENTO tramite COSTRUTTORE
Libro due=new Libro("Il ritorno del re ","Tolkier",1954,1300,17.10f);
List<Libro> elenco=new List<Libro>();
elenco.Add(uno);
elenco.Add(due);

Console.WriteLine($"Il libro preferito da {nome} è {due.getTitolo()}");
int pos=0;
foreach (Libro l in elenco)
    Console.WriteLine($"\t{pos++} - {l}");


