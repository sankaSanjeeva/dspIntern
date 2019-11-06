using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using readWriteMVC_formApp.controller;
using readWriteMVC_formApp.model;
using readWriteMVC_formApp.view;


namespace readWriteMVC_formApp
{
    public partial class Form1 : Form, ViewI
    {
        Model model = new Model();
        string currentID;

        public string fNameText { get { return fName.Text; } set { fName.Text = value; } }
        public string lNameText { get { return lName.Text; } set { lName.Text = value; } }
        public string idText { get { return id.Text; } set { id.Text = value; } }
        public string ageText { get { return age.Text; } set { age.Text = value; } }
        public string heightText { get { return height.Text; } set { height.Text = value; } }
        public string weightText { get { return weight.Text; } set { weight.Text = value; } }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controller cntrl = new Controller(model, this);
            dataGridView1.DataSource = cntrl.display();
        }

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
                currentID = selectedRow.Cells[0].Value.ToString();
                fName.Text = selectedRow.Cells[1].Value.ToString();
                lName.Text = selectedRow.Cells[2].Value.ToString();
                age.Text = selectedRow.Cells[3].Value.ToString();
                height.Text = selectedRow.Cells[4].Value.ToString();
                weight.Text = selectedRow.Cells[5].Value.ToString();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Enter all fields");
            }
            else
            {
                Controller cntrl = new Controller(model, this);
                cntrl.save();
                Form1_Load(sender, e);
                clear_Click(sender, e);
                MessageBox.Show("Save Successfully...");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Enter all fields");
            }
            else
            {
                Controller cntrl = new Controller(model, this);
                cntrl.update(currentID);
                Form1_Load(sender, e);
                clear_Click(sender, e);
                MessageBox.Show("Update Successfully...");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(id.Text == "")
            {
                MessageBox.Show("Select the row you need to delete");
            }
            else
            {
                Controller cntrl = new Controller(model, this);
                cntrl.delete();
                Form1_Load(sender, e);
                clear_Click(sender, e);
                MessageBox.Show("Delete Successfully...");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            fName.Text = lName.Text = id.Text = age.Text = height.Text = weight.Text = "";
        }

        public bool isEmpty()
        {
            if(fName.Text == "" || lName.Text == "" || id.Text == "" || age.Text == "" || height.Text == "" || weight.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
