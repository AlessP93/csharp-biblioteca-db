using System.Data.SqlClient;

string stringaDiConnessione = "Data Source=localhost;" + 
    "Initial Catalog=db-library;Integrated Security=True";

SqlConnection connessioneSql = new SqlConnection(stringaDiConnessione);

try
{
    connessioneSql.Open();
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
finally
{
    connessioneSql.Close();
}

//program cs vecchio
public class Documenti
{
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public bool Stato { get; set; }
    public int Scaffale { get; set; }
    public string Autore { get; set; }


    public Documenti(string titolo, int anno, string settore, int scaffale, string autore)
    {
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        Stato = false;
        Scaffale = scaffale;
        Autore = autore;
    }

}