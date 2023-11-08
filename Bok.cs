using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLibrary_HyperHedgseHogs
{
    public abstract class Bok
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public string ISBN { get; set; }

        public Bok(string titel, string författare, string isbn)
        {
            Titel = titel;
            Författare = författare;
            ISBN = isbn;
        }
        public virtual void SkrivUtInfo()
        {
            Console.WriteLine($"Titel: {Titel}\nFörfattare: {Författare}\nISBN: {ISBN}");
        }
    }
}
