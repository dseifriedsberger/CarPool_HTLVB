namespace CarPool_HTLVB.Components
{
    public class AuthService
    {
        public bool Authenticate(User user)
        {
            // Hier können Sie die Benutzerauthentifizierung logik implementieren.
            // Zum Beispiel: Überprüfen Sie Benutzername und Passwort gegen eine Datenbank.

            // Beispielhaft: Einfache Überprüfung auf Gleichheit.
            return user.Username == "dseif" && user.Password == "1234";
        }
    }

}
