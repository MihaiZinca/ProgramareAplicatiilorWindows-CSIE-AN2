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

namespace Seminar12_BD
{
    public partial class FormularStudent : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Facultate;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public FormularStudent()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Studenti(Id, Nume, Medie)" + "VALUES(@id,@nume,@medie)", connection);
            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(tbId.Text));
            sqlCommand.Parameters.AddWithValue("@nume", tbNume.Text);
            sqlCommand.Parameters.AddWithValue("@medie", decimal.Parse(tbMedie.Text));
            //ori add(specificam tipul), addRamge(care adauga un range-list), addWithValue(fara tip de date)
            sqlCommand.ExecuteNonQuery();//cate nr de randuri s au inserat gen
            connection.Close();
            MessageBox.Show("S-a introdus studentul!");
            this.Close();

        }
    }
}
