using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using readWriteMVC_formApp.model;
using readWriteMVC_formApp.view;

namespace readWriteMVC_formApp.controller
{
    class Controller
    {
        SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=studentDetailsDB;Data Source=DESKTOP-RHP5OGQ\MSSQLSERVER_16");

        Model model;
        ViewI formView;

        public Controller(Model model, ViewI view)
        {
            this.model = model;
            this.formView = view;
        }

        public DataTable display()
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id, fName, lName, age, heights, weights from studentDetails";
            cmd.ExecuteNonQuery();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            cnn.Close();
            return table;
        }

        public void save()
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into studentDetails (id, fName, lName, age, heights, weights) values('" + formView.idText + "', '" + formView.fNameText + "', '" + formView.lNameText + "', '" + formView.ageText + "', '" + formView.heightText + "', '" + formView.weightText + "'); ";
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void update(string currentID)
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update studentDetails set id='" + formView.idText + "',fName='" + formView.fNameText + "',lName='" + formView.lNameText + "',age='" + formView.ageText + "',heights='" + formView.heightText + "',weights='" + formView.weightText + "' where id='" + currentID + "';";
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void delete()
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from studentDetails where id='" + formView.idText + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
