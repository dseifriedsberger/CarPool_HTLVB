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
            string sql = $"SELECT UserID, FirstName, LastName, EMail, Password, SchoolClass, Teacher, MobileNumber FROM Users WHERE EMail = '{user.EMailAddress}'";
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=CARPOOL;Uid=root;Pwd=1234;");
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader(); 
                while(reader.Read())
                {
                    userToStore.UserID = Convert.ToInt32(reader["UserID"]); 
                    userToStore.FirstName = reader["FirstName"].ToString();
                    userToStore.LastName = reader["LastName"].ToString();
                    userToStore.EMailAddress = reader["EMail"].ToString();
                    userToStore.Password = reader["Password"].ToString();
                    userToStore.SchoolClass = reader["SchoolClass"].ToString();
                    if (reader["Teacher"].ToString()=="1") {
                        userToStore.Teacher = true;
                    }
                    else {
                        userToStore.Teacher = false;
                    }
                    userToStore.MobileNumber = reader["MobileNumber"].ToString();

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
