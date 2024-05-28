using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinAndraOchSista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bHämta_Click(object sender, EventArgs e)
        {
            string sSQLconnectionstring = "Server=ASUS-LJL2RG0A21\\SQLEXPRESS;Database=jagvetinte;Integrated Security=True";
            string InputSQL = "SELECT * FROM Table15";
            int iRows = 0;


            SqlConnection conx;
            conx = new SqlConnection();
            conx.ConnectionString = sSQLconnectionstring;
            conx.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conx;
            cmd.CommandText = InputSQL;
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.listBox1.Items.Add(reader.GetString(2));
                    iRows = iRows + 1;
                } 
                this.Text = iRows.ToString();
            }
            reader.Close();
           
        }
        private void bRadera_Click(object sender, EventArgs e)
        {
            string sSQLconnectionstring = "Server=ASUS-LJL2RG0A21\\SQLEXPRESS;Database=jagvetinte;Integrated Security=True";
            string InputSQL = "DELETE FROM Table15 WHERE (Ålder = '" + this.listBox1.SelectedItem.ToString() + "')";


            SqlConnection conx;
            conx = new SqlConnection();     
            conx.ConnectionString = sSQLconnectionstring;
            conx.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conx;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = InputSQL;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conx.Close();
        }

        private void bSkapa_Click(object sender, EventArgs e)
        {

        }

      
    }
}
