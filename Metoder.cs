namespace VirtualLibrary_HyperHedgseHogs
{
    public static class Metoder
    {
        public static List<Media> HämtaMediaLista()
        {
            List<Media> mediaLista = new()
            {
                new Bok("Den gamle mannen och havet", "Ernest Hemingway", "9780140395821"),
                new Bok("Hundraåringen som försvann", "Jonas Jonasson", "9780143787076"),
                new Bok("To Kill a Mockingbird", "Harper Lee", "9780060914269"),
                new Bok("The Lord of the Rings", "J.R.R. Tolkien", "9780006224023"),
                new Bok("1984", "George Orwell", "9780140139561"),
                new Bok("The Great Gatsby", "F. Scott Fitzgerald", "9781593251699"),
                new Bok("Pride and Prejudice", "Jane Austen", "9780140623561"),
                new Bok("Wuthering Heights", "Emily Brontë", "9780140437578"),
                new Bok("Jane Eyre", "Charlotte Brontë", "9780140437072"),
                new Bok("Little Women", "Louisa May Alcott", "9780141934562"),
                new Ebok("Den gamle mannen och havet", "Ernest Hemingway", "9780140395821", "1 TB", "https://example.com/den-gamle-mannen-och-havet.epub"),
                new Ebok("Hundraåringen som försvann", "Jonas Jonasson", "9780143787076", "2 MB", "https://example.com/hundraåringen-som-försvann.epub"),
                new Ebok("To Kill a Mockingbird", "Harper Lee", "9780060914269", "2 GB", "https://example.com/to-kill-a-mockingbird.epub"),
                new Ebok("The Lord of the Rings", "J.R.R. Tolkien", "9780006224023", "4 GB", "https://example.com/the-lord-of-the-rings.epub"),
                new Ebok("1984", "George Orwell", "9780140139561", "1 GB", "https://example.com/1984.epub"),
                new Ebok("The Great Gatsby", "F. Scott Fitzgerald", "9781593251699", "1 MB", "https://example.com/the-great-gatsby.epub"),
                new Ebok("Pride and Prejudice", "Jane Austen", "9780140623561", "2 B", "https://example.com/pride-and-prejudice.epub"),
                new Ebok("Wuthering Heights", "Emily Brontë", "9780140437578", "3 TB", "https://example.com/wuthering-heights.epub"),
                new Ebok("Jane Eyre", "Charlotte Brontë", "9780140437072", "2 GB", "https://example.com/jane-eyre.epub"),
                new Ebok("Little Women", "Louisa May Alcott", "9780141934562", "2 GB", "https://example.com/little-women.epub"),
            };

            return mediaLista;
        }

        public static void LoopaOchSkrivUt(List<Media> mediaLista)
        {
            foreach (var media in mediaLista)
            {
                media.SpelaUpp();
            }
        }
    }
}
