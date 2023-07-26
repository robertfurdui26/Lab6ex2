using System;
using System.Runtime.ConstrainedExecution;

namespace Lab6ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*• Ex 2
Scrieti un program care va modela un autoturism. Un autoturism va avea o
marca (string), un numar de inmatriculare (string), precum si o
capacitate cilindrica(int).
Autoturismul va avea:
 Campurile corespunzatoare caracteristicilor autoturismului.
 Un constructor care va initializa campurile acestuia
 O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca,
numarDeInmatriculare, capacitateCilindrica”.
Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii
xml pentru metodele publice.
Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le
metodele “Tipareste”*/


            Car auto1 = new Car("Audi", "Ab67dar", 1800);
            Console.WriteLine("Detalii auto1:");
            auto1.Tipareste();

            Car auto2 = new Car("Mercedes", "ab56rfd", 7000);
            Console.WriteLine("Detalii auto2");
            auto2.Tipareste();
        }
    }
}