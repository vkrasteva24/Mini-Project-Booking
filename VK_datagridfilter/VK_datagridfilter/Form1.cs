using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VK_datagridfilter.authenticate;
using VK_datagridfilter;


namespace VK_datagridfilter
{
    public partial class Form1 : Form
    {
        private Users authenticatedUser;
        public Form1(Users user)
        {
            authenticatedUser = user;
            InitializeComponent();

            loggedIn.Text = $"Logged in as: {authenticatedUser.name}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC02\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "SELECT * FROM Restaurant WHERE 1 = 1";

                List<string> conditions = new List<string>();

                if (comboBox1.SelectedItem != null)
                {
                    conditions.Add("restaurant = @restaurant");
                }

                if (comboBox2.SelectedItem != null)
                {
                    conditions.Add("num_guests = @num_guests");
                }

                if (comboBox3.SelectedItem != null)
                {
                    conditions.Add("time_res = @time_res");
                }

                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                if (comboBox1.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@restaurant", comboBox1.SelectedItem.ToString());
                }

                if (comboBox2.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@num_guests", comboBox2.SelectedItem.ToString());
                }

                if (comboBox3.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@time_res", comboBox3.SelectedItem.ToString());
                }



                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void clear_filters_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void book_Click(object sender, EventArgs e)
        {
            using (booking userInputForm = new booking())
            {
                userInputForm.ShowDialog();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete deleteForm = new delete(authenticatedUser);
            deleteForm.ShowDialog();
        }
    }
}

