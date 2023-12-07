using MySqlConnector;
using Dapper;
namespace CarPool_HTLVB.Components
{
    public class AuthService
    { 
        public List<IUser> UserList = new List<IUser>();
        public bool Authenticate(User user, out IUser curUser)
        {
            IUser userToStore = new User();
            string sql = $"SELECT UserName, Password, Firstname, SchoolClass FROM Users WHERE UserName = '{user.EMailAddress}'";
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=CARPOOL;Uid=root;Pwd=1234;");
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader(); 
                while(reader.Read())
                {
                    
                    userToStore.EMailAddress = reader["UserName"].ToString();
                    userToStore.Password = reader["Password"].ToString();
                    userToStore.FirstName = reader["Firstname"].ToString();
                    userToStore.SchoolClass = reader["SchoolClass"].ToString();

                    UserList.Add(userToStore);
                }
                if (UserList != null)
                {
                    foreach (User userToCheck in UserList)
                    {
                        if (user.EMailAddress == userToCheck.EMailAddress && user.Password == userToCheck.Password)
                        {
                            curUser = userToCheck;
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            curUser = null;
            return false;
        }
    }

}
