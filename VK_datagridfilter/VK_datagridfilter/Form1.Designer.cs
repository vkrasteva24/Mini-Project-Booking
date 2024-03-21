namespace VK_datagridfilter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            search = new Button();
            clear_filters = new Button();
            book = new Button();
            loggedIn = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.PeachPuff;
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Horizon Dining", "SeaHouse Brunch" });
            comboBox1.Location = new Point(124, 84);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Restaurant";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.PeachPuff;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "2", "4", "5", "6" });
            comboBox2.Location = new Point(251, 84);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "Number of Guests";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.PeachPuff;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "10:00", "11:00", "12:00", "17:00", "18:00", "19:00" });
            comboBox3.Location = new Point(378, 84);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 2;
            comboBox3.Text = "Time";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(124, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(529, 212);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(124, 30);
            label1.Name = "label1";
            label1.Size = new Size(238, 30);
            label1.TabIndex = 4;
            label1.Text = "Book your reservation!";
            label1.Click += label1_Click;
            // 
            // search
            // 
            search.BackColor = Color.PeachPuff;
            search.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            search.FlatAppearance.BorderSize = 0;
            search.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            search.Location = new Point(124, 350);
            search.Name = "search";
            search.Size = new Size(99, 32);
            search.TabIndex = 5;
            search.Text = "SEARCH";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // clear_filters
            // 
            clear_filters.BackColor = Color.PeachPuff;
            clear_filters.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            clear_filters.FlatAppearance.BorderSize = 0;
            clear_filters.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clear_filters.Location = new Point(505, 84);
            clear_filters.Name = "clear_filters";
            clear_filters.Size = new Size(148, 24);
            clear_filters.TabIndex = 6;
            clear_filters.Text = "CLEAR FILTERS";
            clear_filters.UseVisualStyleBackColor = false;
            clear_filters.Click += clear_filters_Click;
            // 
            // book
            // 
            book.BackColor = Color.PeachPuff;
            book.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            book.FlatAppearance.BorderSize = 0;
            book.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            book.Location = new Point(241, 350);
            book.Name = "book";
            book.Size = new Size(75, 32);
            book.TabIndex = 7;
            book.Text = "BOOK";
            book.UseVisualStyleBackColor = false;
            book.Click += book_Click;
            // 
            // loggedIn
            // 
            loggedIn.AutoSize = true;
            loggedIn.BackColor = Color.PeachPuff;
            loggedIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            loggedIn.Location = new Point(653, 398);
            loggedIn.Name = "loggedIn";
            loggedIn.Size = new Size(0, 20);
            loggedIn.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(463, 350);
            button1.Name = "button1";
            button1.Size = new Size(190, 32);
            button1.TabIndex = 9;
            button1.Text = "View Bookings";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_3127102_1280;
            ClientSize = new Size(800, 427);
            Controls.Add(button1);
            Controls.Add(loggedIn);
            Controls.Add(book);
            Controls.Add(clear_filters);
            Controls.Add(search);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DataGridView dataGridView1;
        private Label label1;
        private Button search;
        private Button clear_filters;
        private Button book;
        private Label loggedIn;
        private ComboBox res_type;
        private Button button1;
    }
}