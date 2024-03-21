namespace VK_datagridfilter
{
    partial class delete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            table_num = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PeachPuff;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(396, 243);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 43);
            label1.Name = "label1";
            label1.Size = new Size(153, 30);
            label1.TabIndex = 1;
            label1.Text = "View Bookings";
            // 
            // table_num
            // 
            table_num.BackColor = Color.PeachPuff;
            table_num.ForeColor = SystemColors.WindowText;
            table_num.FormattingEnabled = true;
            table_num.Items.AddRange(new object[] { "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211" });
            table_num.Location = new Point(508, 124);
            table_num.Name = "table_num";
            table_num.Size = new Size(137, 23);
            table_num.TabIndex = 2;
            table_num.Text = "Table Number";
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(508, 152);
            button1.Name = "button1";
            button1.Size = new Size(137, 27);
            button1.TabIndex = 10;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.Location = new Point(508, 105);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 11;
            label2.Text = "Choose a table to delete:";
            // 
            // button2
            // 
            button2.BackColor = Color.PeachPuff;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(612, 349);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 12;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_3127102_1280;
            ClientSize = new Size(699, 393);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(table_num);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "delete";
            Text = "delete";
            Load += delete_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox table_num;
        private Button button1;
        private Label label2;
        private Button button2;
    }
}