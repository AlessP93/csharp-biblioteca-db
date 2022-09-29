using System.Reflection.Metadata;
public class Utente
{
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public double Numero { get; set; }
    public bool Registrato { get; set; }

    public Utente(string cognome, string nome, string email, string password, double numero)
    {
        Cognome = cognome;
        Nome = nome;
        Email = email;
        Password = password;
        Numero = numero;
    }
}


