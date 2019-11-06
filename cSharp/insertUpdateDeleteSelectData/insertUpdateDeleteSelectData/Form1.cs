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

namespace insertUpdateDeleteSelectData
{
    public partial class form : Form
    {
        // CREATE CONNECTION
        SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=studentDetailsDB;Data Source=DESKTOP-RHP5OGQ\MSSQLSERVER_16");
        string currentId;

        public form()
        {
            InitializeComponent();
        }

        // DISPLAY DATA
        public void displayData()
        {
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id, fName, lName, age, heights, weights from studentDetails";
            cmd.ExecuteNonQuery();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            cnn.Close();
        }

        // DISPLAY DATA WHEN LOAD
        private void form_Load(object sender, EventArgs e)
        {
            displayData();
        }

        // GET SELECTED VALUE OF ROW IN GRIDEVIEW
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                id.Text = selectedRow.Cells[0].Value.ToString();
                currentId = selectedRow.Cells[0].Value.ToString();
                fName.Text = selectedRow.Cells[1].Value.ToString();
                lName.Text = selectedRow.Cells[2].Value.ToString();
                age.Text = selectedRow.Cells[3].Value.ToString();
                heights.Text = selectedRow.Cells[4].Value.ToString();
                weights.Text = selectedRow.Cells[5].Value.ToString();
            }
        }

        // CLEAR VALUES WHICH ARE IN TEXT BOXES
        private void clear_Click(object sender, EventArgs e)
        {
            fName.Text = lName.Text = id.Text = age.Text = heights.Text = weights.Text = "";
        }

        // ADD NEW DATA
        private void save_Click(object sender, EventArgs e)
        {
            if (fName.Text != "" && lName.Text != "" && id.Text != "" && age.Text != "" && heights.Text != "" && weights.Text != "")
            {
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into studentDetails (id, fName, lName, age, heights, weights) values('" + id.Text + "', '" + fName.Text + "', '" + lName.Text + "', '" + age.Text + "', '" + heights.Text + "', '" + weights.Text + "'); ";
                cmd.ExecuteNonQuery();
                cnn.Close();
                displayData();
                MessageBox.Show("Data saved ...");

                fName.Text = lName.Text = id.Text = age.Text = heights.Text = weights.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter all fields");
            }

        }

        // DELETE DATA
        private void delete_Click(object sender, EventArgs e)
        {
            if(id.Text == "")
            {
                MessageBox.Show("Please enter ID whitch you want to delete");
            }
            else
            {
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from studentDetails where id='" + id.Text + "'";
                cmd.ExecuteNonQuery();
                cnn.Close();
                displayData();
                MessageBox.Show("Delete Succesfully...");
                fName.Text = lName.Text = id.Text = age.Text = heights.Text = weights.Text = "";
            }
        }
        
        // UPDATE DATA
        private void update_Click(object sender, EventArgs e)
        {
            if (fName.Text != "" && lName.Text != "" && id.Text != "" && age.Text != "" && heights.Text != "" && weights.Text != "")
            {
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update studentDetails set id='" + id.Text + "',fName='" + fName.Text +"',lName='" + lName.Text + "',age='" + age.Text + "',heights='" +heights.Text + "',weights='" + weights.Text+ "' where id='" + currentId + "';";
                cmd.ExecuteNonQuery();
                cnn.Close();
                displayData();
                MessageBox.Show("Update Succesfully...");
                fName.Text = lName.Text = id.Text = age.Text = heights.Text = weights.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter all fields to update");
            }
        }

        private void lName_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fName_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }
