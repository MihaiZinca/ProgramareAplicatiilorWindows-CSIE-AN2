using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesiuneFacultati
{
    public partial class FormAdaugare : Form
    {
        List<Student> listaStudenti=new List<Student>();
        public FormAdaugare()
        {
            InitializeComponent();
        }
        public List<Student>ListaStudenti { get => listaStudenti; }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            try
            {

                int matricol = int.Parse(tbNrMat.Text);
                string nume=tbNume.Text;
                float medie = Convert.ToSingle(tbMedie.Text);

                Student s=new Student(matricol, nume, medie);
                listaStudenti.Add(s);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbNrMat.Clear();
                tbNume.Clear();
                tbMedie.Clear();
            }
            
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
