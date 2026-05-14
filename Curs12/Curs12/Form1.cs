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

namespace Curs12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string scmd = "select * from persoane";
            con.Open();
            SqLConmand obcnd = new SqlCommand(scmd, con);
            SqlDataReader dr = obcmd.ExecuteReader(); 
            dt.Load(dr);
            gv.DataSource = dt;
            con.CloseO;

            //partea de sus pusa intr o functie separata de vizualizare
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sm = "700", sn = "Valentina";
            string ins_cmd = "insert into persoane values(";
            ins_cmd+=sm+","+sn++"')";
            con.Opne();
            SqLConmand obcmd = new SqlCommand(ins_cmd, con);
            try
            {
                int k = obcmd.ExecuteNonQuery();
                MessageBox.Show("Inserat: " + k.ToString() + " tupluri");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            string del_cmd = "delete from persoane where marca =@marca";
            con.Opne();
            SqLConmand obcmd = new SqlCommand(del_cmd, con);
            obcmd.Parameters.Add("@marca", SqlDbType.Int).Value = int.Parse(tbMarca.Text);
            try
            {
                int k = obcmd.ExecuteNonQuery();
                MessageBox.Show("Sters: " + k.ToString() + " tupluri");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
