using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VK_datagridfilter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VK_datagridfilter
{
    public class authenticate
    {

        public class Users
        {
            public string username { get; set; }
            public string password { get; set; }
            public string name { get; set; }

        }

        public class DatabaseManager
        {
            public static Users AuthenticateUser(string username, string password)
            {
                Users user = RetrieveUserInformation(username, password);
                return user;
            }


            private static Users RetrieveUserInformation(string username, string password)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC02\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
                {
                    sqlCon.Open();

                    string Query = "SELECT COUNT(1) FROM Users Where username=@Username AND password=@Password";

                    using (SqlCommand loginCmd = new SqlCommand(Query, sqlCon))
                    {

                        loginCmd.CommandType = CommandType.Text;

                        loginCmd.Parameters.AddWithValue("@Username", username);
                        loginCmd.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(loginCmd.ExecuteScalar()); // Execute query and get the count

                        if (count == 1)

                        {
                            string query2 = "SELECT name from Users where username=@Username AND password=@Password";
                            SqlCommand cmd = new SqlCommand(query2, sqlCon);
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@Username", username);
                                cmd.Parameters.AddWithValue("@Password", password);
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string name = reader["name"].ToString();
                                        return new Users { name = name };
                                    }
                                }
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("Password or username is incorrect. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                        return null;
                    }
                }
            }
        }
    }
}
