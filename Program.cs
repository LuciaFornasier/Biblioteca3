// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string nome;
nome="lucia";

/*
Libro:classe
libro():costruttore di default(==senza parametri) della classe libro
uno: istanza della classe libro noto come OGGETTO cioè una VARIABILE DI TIPO LIBRO (CLASSE)
*/
Autore orwell=new Autore("Orwell","George",new DateOnly(1903,6,25),true);
Autore yourcenar=new Autore("Yourcenar", "Marguerite",new DateOnly(1903,6,8),false);
Libro  uno=new Libro("1984",orwell,1949,333);// DICHIARAZIONE E ASSEGNAMENTO tramite COSTRUTTORE
Libro due=new Libro("Il ritorno del re ","Tolkier",1954,1300,17.10f);
Console.WriteLine($"Il libro preferito da {nome} è {due.getTitolo()}");
console.WriteLine(orwell);
console.WriteLine(yourcenar);
int idx=0;
foreach (Libro liber in new Libro[]{uno,due})
    Console.WriteLine($"Libro n.{++idx}:{liber}");
