using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static VK_datagridfilter.authenticate;

namespace VK_datagridfilter
{
    public partial class delete : Form
    {
        private Users user;
        public delete(Users user)
        {
            InitializeComponent();
            this.user = user;
        }
        SqlConnection sql;

        private void delete_Load(object sender, EventArgs e)
        {


            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC02\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT * FROM Bookings WHERE 1 = 1";

                List<string> conditions = new List<string>();

                if (table_num.SelectedItem != null)
                {
                    conditions.Add("table_num = @tNumber");
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                if (table_num.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@tNumber", table_num.SelectedItem.ToString());
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC02\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                sqlCon.Open();
                string deleteBooking = "Delete From Bookings WHERE table_num=@tNumber";
                SqlCommand cmd = new SqlCommand(deleteBooking, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@tNumber", table_num.Text);
                cmd.ExecuteNonQuery();


                DialogResult result = MessageBox.Show("Are you sure you want to delete this booking?", "Warning!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your note has been deleted!", "Message", MessageBoxButtons.OK);
                    this.Hide();
                    delete deleteForm = new delete(this.user);
                    deleteForm.ShowDialog();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Failed to delete booking!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(this.user);
            form1.ShowDialog();
        }
    }
}
