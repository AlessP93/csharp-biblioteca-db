public class Libro : Documenti
{
    public string Isbn { get; set; }
    public int Pagine { get; set; }

    public Libro(string titolo, int anno, string settore, int scaffale, string autore, string isbn, int pagine) : base(titolo, anno , settore, scaffale, autore )
    {
        Isbn = isbn;
        Pagine = pagine;
    }
        
}
