using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace StudentDetails
{
    public partial class Student_details : Form
    {
        string filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\studentDetails.txt";
        DataTable table = new DataTable();

        public Student_details()
        {
            InitializeComponent();
        }

        private void Student_details_Load(object sender, EventArgs e)
        {
            // Columns names of table
            table.Columns.Add("First name", typeof(string));
            table.Columns.Add("Last name", typeof(string));
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Age", typeof(string));
            table.Columns.Add("Weight", typeof(string));
            table.Columns.Add("Height", typeof(string));

            dataGridView1.DataSource = table;

            // Read line by line from text file
            string[] lines = File.ReadAllLines(filePath);
            string[] value;

            for(int i=0; i<lines.Length; i++)
            {
                value = lines[i].Split(',');
                table.Rows.Add(value);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Save button
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Check whether all fields are typed
            if(fName.Text == "" || lName.Text == "" || id.Text == "" || age.Text == "" || height.Text == "" || weight.Text == "")
            {
                MessageBox.Show("Enter all fields");
            }
            // Save data
            else
            {
                string line = fName.Text + "," + lName.Text + "," + id.Text + "," + age.Text + "," + height.Text + "," + weight.Text;

                using (StreamWriter file = new StreamWriter(filePath, true))
                {
                    file.WriteLine(line);
                }

                // Display saved data in a dataGride
                dataGridView1.DataSource = table;
                string[] value;

                value = line.Split(',');
                table.Rows.Add(value);

                MessageBox.Show("Saved ...");

                // Clear all fields to
                fName.Text = lName.Text = id.Text = age.Text= height.Text = weight.Text = "";
            }
        }

        // Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            fName.Text = lName.Text = id.Text = age.Text = height.Text = weight.Text = "";
        }
    }
}
