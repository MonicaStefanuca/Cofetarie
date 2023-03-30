using System;
namespace InregistrareClienti
{
    public class Client
    {
        private int IdClient;
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public Client(int id, string nume, string prenume, string email, string telefon)
        {
            IdClient = id;
            Nume = nume;
            Prenume = prenume;
            Email = email;
            Telefon = telefon;
        }
    }
}
