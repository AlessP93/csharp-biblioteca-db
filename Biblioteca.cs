public class Biblioteca
{
    List<Utente> Utenti = new List<Utente>();
    List<Film> Films = new List<Film>();
    List<Libro> Libri = new List<Libro>();

    public void AggiungiUtente(Utente utente)
    {
        Utenti.Add(utente);
        utente.Registrato = true;
    }

    public void EliminaUtente(Utente utente)
    {
        Utenti.Remove(utente);
        utente.Registrato = false;
    }

    public void AggiungiFilm(Film film)
    {
        Films.Add(film);
        
    }
    public void RimuoviFilm(Film film)
    {
        Films.Remove(film);

    }
    public void AggiungiLibro(Libro libro)
    {
        Libri.Add(libro);

    }
    public void RimuoviLibro(Libro libro)
    {
        Libri.Remove(libro);

    }

    public List<Documenti>CercaObj(string cerca)
    {
        List<Documenti> risultati = new List<Documenti>();

        foreach (Film film in Films)
        {
            if (film.Seriale == cerca)
            {
                risultati.Add(film);
            }
            
        }
        foreach (Libro libro in Libri)
        {
            if (libro.Isbn == cerca)
            {
                risultati.Add(libro);
            }
        }
        return risultati;
    }
}
