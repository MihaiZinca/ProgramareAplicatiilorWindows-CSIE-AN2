using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesiuneFacultati
{
    public partial class Form1 : Form
    {
        List<Student> lstStud=new List<Student>();

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=tblStudenti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();
        }

        public void SalvareBD()
        {
            con.Open();
            foreach(Student student in lstStud)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblStudenti(Matricol,Nume,Medie) VALUES (@mat,@nume,@medie)", con);
                cmd.Parameters.AddWithValue("@mat", student.Matricol);
                cmd.Parameters.AddWithValue("@nume", student.Nume);
                cmd.Parameters.AddWithValue("@medie", student.Medie);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void btnAdaugareStud_Click(object sender, EventArgs e)
        {
            FormAdaugare fa=new FormAdaugare();
            if(fa.ShowDialog() == DialogResult.OK)
            {
                lstStud.AddRange(fa.ListaStudenti);
                dgvStud.DataSource = null;
                dgvStud.DataSource = lstStud;
            }
        }

        private void prviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd=new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog pdlg = new PrintPreviewDialog { Document = pd };
            pdlg.ShowDialog();
        }

        private void pp(object sender, PrintPageEventArgs e)
        {
            Font fontTitlu = new Font("Arial", 12, FontStyle.Bold);
            Font fontText = new Font("Arial", 10);
            float y = 20;

            e.Graphics.DrawString("MEDII STUDENTI", fontTitlu, Brushes.Black, 20, y);
            y += 25;
            foreach(Student s in lstStud)
            {
                e.Graphics.DrawString($"{s.Nume}-{s.Matricol}-{s.Medie}", fontText, Brushes.Black, 40, y);
                y += 25;
            }
        }

        private void dgvStud_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Student s = lstStud[e.RowIndex];
            FormModificare fm = new FormModificare(s);
            if(fm.ShowDialog() == DialogResult.OK)
            {
                dgvStud.Refresh();
            }
        }

        private void salvareInBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvareBD();
            FormDB fdb = new FormDB();
            fdb.Show();

        }
    }
}
