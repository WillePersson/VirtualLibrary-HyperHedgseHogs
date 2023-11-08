using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLibrary_HyperHedgseHogs
{
    internal class Ebok : Bok
    {
        public string Filstorlek { get; set; }
        public string DownloadUrl { get; set; }

        public Ebok(string titel, string författare, string isbn, string filstorlek, string downloadUrl) : base(titel, författare, isbn)
        {
            Filstorlek = filstorlek;
            DownloadUrl = downloadUrl;
        }

        public override void SkrivUtInfo()
        {
            base.SkrivUtInfo();
            Console.WriteLine($"\nFilstorlek: {Filstorlek}\nDownloadURL: {DownloadUrl}");
        }
    }
}
