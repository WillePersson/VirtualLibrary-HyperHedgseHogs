namespace VirtualLibrary_HyperHedgseHogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var minMedia = Metoder.HämtaMediaLista();
            Metoder.LoopaOchSkrivUt(minMedia);
        }
    }
}