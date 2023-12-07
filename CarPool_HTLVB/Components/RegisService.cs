using Dapper;
using MySqlConnector;
namespace CarPool_HTLVB.Components
{
    public class RegisService
    {
        public bool RegistrateUser(IUser user)
        {
            string sql = $"INSERT INTO Users () VALUES()";
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=CARPOOL;Uid=root;Pwd=1234;");
            MySqlCommand command = new MySqlCommand(sql, connection);
            return true;
        }
    }
}
