Biblioteca biblioteca = new Biblioteca();

Utente utente = new Utente("Rossi", "Mario", "mariorossi@mario,it", "12345", 3899184033);

Film film = new Film("Top Gun", 1986, "Azione", 11, "Jhon Smith", "367273", 120);

Libro libro = new Libro("Avatar", 2022, "Fantascienza", 92, "Jhon Smith", "34526789384", 188);

Biblioteca.AggiungiUtente(utente);
Biblioteca.AggiungiFilm(film);
Biblioteca.AggiungiLibro(libro);
