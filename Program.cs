using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // generička klasa za Artikal sa
    // cenom bilo kog tipa
    class Artikal<T>
    {
        private string naziv;
        private T cena;
        public T Cena { get => cena; set => cena = value; }
        public string Naziv
        {
            get { return naziv.ToUpper(); }
            set { naziv = value; }
        }
        public override string ToString()
        {
            return String.Format("{0}: {1}",
                naziv.ToString(), Cena.ToString());
        }
        // Metoda koja vraća cenu artikla u eurima na osnovu kursa
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // artikal sa cenom tipa int
            Artikal<int> a1 = new Artikal<int>();
            a1.Cena = 100;
            // artikal sa cenom tipa string
            Artikal<string> a2 = new Artikal<string>();
            a2.Cena = "stopedeseteura";
        }
    }
}
