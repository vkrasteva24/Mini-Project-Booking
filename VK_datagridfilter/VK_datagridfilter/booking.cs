using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_datagridfilter
{
    internal class booking : Form
    {
        public booking()
        {
            InitializeComponent();
        }

        private TextBox guestName;
        private TextBox phone;
        private ComboBox restaurant;
        private ComboBox table_num;
        private Button book;
        private Label label1;
        private ComboBox res_type;
        private ComboBox time_res;

        private void InitializeComponent()
        {
            guestName = new TextBox();
            phone = new TextBox();
            restaurant = new ComboBox();
            time_res = new ComboBox();
            table_num = new ComboBox();
            book = new Button();
            label1 = new Label();
            res_type = new ComboBox();
            SuspendLayout();
            // 
            // guestName
            // 
            guestName.BackColor = Color.PeachPuff;
            guestName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guestName.Location = new Point(76, 72);
            guestName.Name = "guestName";
            guestName.PlaceholderText = "Name";
            guestName.Size = new Size(193, 29);
            guestName.TabIndex = 0;
            // 
            // phone
            // 
            phone.BackColor = Color.PeachPuff;
            phone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phone.Location = new Point(301, 72);
            phone.Name = "phone";
            phone.PlaceholderText = "Phone Number";
            phone.Size = new Size(193, 29);
            phone.TabIndex = 1;
            // 
            // restaurant
            // 
            restaurant.BackColor = Color.PeachPuff;
            restaurant.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            restaurant.FormattingEnabled = true;
            restaurant.Items.AddRange(new object[] { "Horizon Dining", "SeaHouse Brunch" });
            restaurant.Location = new Point(76, 129);
            restaurant.Name = "restaurant";
            restaurant.Size = new Size(193, 29);
            restaurant.TabIndex = 3;
            restaurant.Text = "Restaurant";
            // 
            // time_res
            // 
            time_res.BackColor = Color.PeachPuff;
            time_res.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            time_res.FormattingEnabled = true;
            time_res.Items.AddRange(new object[] { "10:00", "11:00", "12:00", "17:00", "18:00", "19:00" });
            time_res.Location = new Point(301, 129);
            time_res.Name = "time_res";
            time_res.Size = new Size(193, 29);
            time_res.TabIndex = 4;
            time_res.Text = "Time of Reservation";
            // 
            // table_num
            // 
            table_num.BackColor = Color.PeachPuff;
            table_num.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            table_num.FormattingEnabled = true;
            table_num.Items.AddRange(new object[] { "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211" });
            table_num.Location = new Point(76, 187);
            table_num.Name = "table_num";
            table_num.Size = new Size(193, 29);
            table_num.TabIndex = 5;
            table_num.Text = "Table Number";
            // 
            // book
            // 
            book.BackColor = Color.PeachPuff;
            book.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            book.Location = new Point(190, 251);
            book.Name = "book";
            book.Size = new Size(193, 38);
            book.TabIndex = 6;
            book.Text = "Book";
            book.UseVisualStyleBackColor = false;
            book.Click += book_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 7;
            label1.Text = "Create booking!";
            label1.Click += label1_Click;
            // 
            // res_type
            // 
            res_type.BackColor = Color.PeachPuff;
            res_type.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            res_type.FormattingEnabled = true;
            res_type.Items.AddRange(new object[] { "Dinner", "Brunch", "Birthday", "VIP", "VVIP", "Company Dinner" });
            res_type.Location = new Point(301, 187);
            res_type.Name = "res_type";
            res_type.Size = new Size(193, 29);
            res_type.TabIndex = 8;
            res_type.Text = "Reservation Type";
            // 
            // booking
            // 
            BackColor = Color.PeachPuff;
            BackgroundImage = Properties.Resources.background_3127102_1280;
            ClientSize = new Size(553, 334);
            Controls.Add(res_type);
            Controls.Add(label1);
            Controls.Add(book);
            Controls.Add(table_num);
            Controls.Add(time_res);
            Controls.Add(restaurant);
            Controls.Add(phone);
            Controls.Add(guestName);
            Name = "booking";
            Load += booking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void booking_Load(object sender, EventArgs e)
        {

        }

        private void book_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC02\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                sqlCon.Open();

                string availabilityQuery = "SELECT availability FROM Restaurant WHERE table_num = @tNumber";

                SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sqlCon);
                availabilityCmd.Parameters.AddWithValue("@tNumber", table_num.Text);
                string availabilityResult = availabilityCmd.ExecuteScalar().ToString().Trim();

                if (availabilityResult.Equals("Available", StringComparison.OrdinalIgnoreCase))
                {
                    string insertQuery = "INSERT INTO Bookings VALUES (@tNumber, @gName, @pNumber, @restaurant, @timeRes, @res_type)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                    insertCmd.Parameters.AddWithValue("@tNumber", table_num.Text);
                    insertCmd.Parameters.AddWithValue("@gName", guestName.Text);
                    insertCmd.Parameters.AddWithValue("@pNumber", phone.Text);
                    insertCmd.Parameters.AddWithValue("@restaurant", restaurant.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@timeRes", time_res.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@res_type", res_type.SelectedItem.ToString());

                    insertCmd.ExecuteNonQuery();

                    string updateAvailabilityQuery = "UPDATE Restaurant SET availability = 'Not Available' WHERE table_num = @tNumber";
                    SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                    updateAvailabilityCmd.Parameters.AddWithValue("@tNumber", table_num.Text);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    MessageBox.Show("Booking Successful!");
                }
                else
                {
                    MessageBox.Show("Sorry, the room is not available for booking.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

