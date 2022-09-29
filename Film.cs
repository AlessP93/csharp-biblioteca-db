public class Film : Documenti
{
    public string Seriale { get; set; }
    public int Durata { get; set; }

    public Film(string titolo, int anno, string settore, int scaffale, string autore, string seriale, int durata) : base( titolo, anno, settore, scaffale, autore)
    {
        Seriale = seriale;
        Durata = durata;
    }
}
