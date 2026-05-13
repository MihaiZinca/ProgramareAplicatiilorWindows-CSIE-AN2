using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar12_BD
{
    public partial class Form1 : Form
    {
        //stergem spatiile de la TrustServerCertificate  si cele de dupa ca sa nu crape!
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Facultate;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form1()
        {
            InitializeComponent();
        }

        //citire date din baza de date
        private void btnRead_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Studenti", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gvStudenti.DataSource = dt;
            connection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormularStudent fms = new FormularStudent(); //instantiere
            fms.Show(); //ori cu showdialog 
        }
    }
}
