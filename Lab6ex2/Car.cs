using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6ex2
{
    internal class Car
    {
        public string marca;
        private string nrDeInmatriculare;
        public int capacitate;

        public Car(string marca, string nrDeInmatriculare, int capacitate)
        {
            this.marca = marca;
            this.nrDeInmatriculare = nrDeInmatriculare;
            this.capacitate = capacitate;
        }

        public void Tipareste()
        {
            Console.WriteLine($"{marca} {nrDeInmatriculare} {capacitate} cm ");
        }
    }
}
